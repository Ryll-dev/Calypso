using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calypso
{
    internal class TaskbarInfo
    {
        [DllImport("shell32.dll")]
        private static extern UIntPtr SHAppBarMessage(uint dwMessage, ref APPBARDATA pData);

        private const uint ABM_GETTASKBARPOS = 0x00000005;

        public enum TaskbarPosition : uint
        {
            Left = 0,
            Top = 1,
            Right = 2,
            Bottom = 3
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct APPBARDATA
        {
            public uint cbSize;
            public IntPtr hWnd;
            public uint uCallbackMessage;
            public TaskbarPosition uEdge;
            public RECT rc;
            public int lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public static (TaskbarPosition position, int size) GetTaskbarInfo()
        {
            APPBARDATA data = new APPBARDATA();
            data.cbSize = (uint)Marshal.SizeOf(typeof(APPBARDATA));

            UIntPtr result = SHAppBarMessage(ABM_GETTASKBARPOS, ref data);
            if (result == UIntPtr.Zero)
            {
                throw new Exception("Görev çubuğu konumu alınamadı.");
            }

            TaskbarPosition position = data.uEdge;
            int size = 0;
            if (position == TaskbarPosition.Left || position == TaskbarPosition.Right)
            {
                size = data.rc.right - data.rc.left;
            }
            else if (position == TaskbarPosition.Top || position == TaskbarPosition.Bottom)
            {
                size = data.rc.bottom - data.rc.top;
            }
            return (position, size);
        }
    }
}
