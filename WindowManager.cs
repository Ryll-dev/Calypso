using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Calypso
{
    public class ManagedWindow
    {
        public string Title { get; set; }
        public IntPtr Handle { get; set; }
        public uint ProcessId { get; set; }
        public string ExecutablePath { get; set; }
        public Icon Icon { get; set; }
    }

    public static class WindowManager
    {
        [StructLayout(LayoutKind.Sequential)] public struct RECT { public int Left, Top, Right, Bottom; }
        [StructLayout(LayoutKind.Sequential)] public struct PSIZE { public int x, y; }
        [StructLayout(LayoutKind.Sequential)] public struct DWM_THUMBNAIL_PROPERTIES { public uint dwFlags; public RECT rcDestination; public RECT rcSource; public byte opacity; [MarshalAs(UnmanagedType.Bool)] public bool fVisible; [MarshalAs(UnmanagedType.Bool)] public bool fSourceClientAreaOnly; }

        public const uint DWM_TNP_RECTDESTINATION = 0x00000001;
        public const uint DWM_TNP_OPACITY = 0x00000004;
        public const uint DWM_TNP_VISIBLE = 0x00000008;

        [DllImport("dwmapi.dll", PreserveSig = true)] public static extern int DwmRegisterThumbnail(IntPtr dest, IntPtr src, out IntPtr thumbnail);
        [DllImport("dwmapi.dll", PreserveSig = true)] public static extern int DwmUnregisterThumbnail(IntPtr thumbnail);
        [DllImport("dwmapi.dll", PreserveSig = true)] public static extern int DwmQueryThumbnailSourceSize(IntPtr thumbnail, out PSIZE size);
        [DllImport("dwmapi.dll", PreserveSig = true)] public static extern int DwmUpdateThumbnailProperties(IntPtr thumbnail, ref DWM_THUMBNAIL_PROPERTIES props);

        [DllImport("user32.dll", SetLastError = true)] private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")] private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")] private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")] private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")] private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")] private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll")] private static extern bool IsWindowVisible(IntPtr hWnd);
        [DllImport("user32.dll")] private static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll")] private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")] private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
        [DllImport("kernel32.dll")] private static extern uint GetCurrentThreadId();
        [DllImport("user32.dll")] private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);
        [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        private const int SW_RESTORE = 9;
        private const int SW_MINIMIZE = 6;
        private const int SW_SHOWMINNOACTIVE = 7;
        private const uint WM_SYSCOMMAND = 0x0112;
        private static readonly IntPtr SC_MINIMIZE = new IntPtr(0xF020);

        public static void KillProcess(uint pid) { try { Process.GetProcessById((int)pid).Kill(); } catch { } }
        public static void HideTaskbar() { ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE); ShowWindow(FindWindow("Button", null), SW_HIDE); }
        public static void ShowTaskbar() { ShowWindow(FindWindow("Shell_TrayWnd", null), SW_SHOW); ShowWindow(FindWindow("Button", null), SW_SHOW); }

        public static IntPtr GetActiveWindowHandle() => GetForegroundWindow();

        public static List<ManagedWindow> GetOpenWindows()
        {
            var list = new List<ManagedWindow>();
            EnumWindows((hWnd, _) =>
            {
                if (!IsWindowVisible(hWnd) || GetWindowTextLength(hWnd) == 0) return true;
                var sb = new StringBuilder(GetWindowTextLength(hWnd) + 1);
                GetWindowText(hWnd, sb, sb.Capacity);
                GetWindowThreadProcessId(hWnd, out uint pid);
                string path = null; Icon icon = null;
                try { var p = Process.GetProcessById((int)pid); path = p.MainModule.FileName; icon = Icon.ExtractAssociatedIcon(path); } catch { }
                list.Add(new ManagedWindow { Title = sb.ToString(), Handle = hWnd, ProcessId = pid, ExecutablePath = path, Icon = icon });
                return true;
            }, IntPtr.Zero);
            return list;
        }

        public static void ForceActivate(IntPtr hWnd)
        {
            IntPtr fg = GetForegroundWindow();
            uint ct = GetCurrentThreadId();
            GetWindowThreadProcessId(fg, out uint fgT);
            GetWindowThreadProcessId(hWnd, out uint tgtT);
            AttachThreadInput(ct, fgT, true);
            AttachThreadInput(ct, tgtT, true);
            ShowWindowAsync(hWnd, SW_RESTORE);
            SetForegroundWindow(hWnd);
            AttachThreadInput(ct, fgT, false);
            AttachThreadInput(ct, tgtT, false);
        }

        public static void ForceMinimize(IntPtr hWnd)
        {
            uint ct = GetCurrentThreadId();
            GetWindowThreadProcessId(hWnd, out uint tgtT);
            AttachThreadInput(ct, tgtT, true);
            ShowWindowAsync(hWnd, SW_SHOWMINNOACTIVE);
            SendMessage(hWnd, WM_SYSCOMMAND, SC_MINIMIZE, IntPtr.Zero);
            AttachThreadInput(ct, tgtT, false);
        }

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, uint nFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        public static void ToggleWindow(IntPtr hWnd)
        {
            if (GetActiveWindowHandle() == hWnd) ForceMinimize(hWnd); else ForceActivate(hWnd);
        }
    }
}