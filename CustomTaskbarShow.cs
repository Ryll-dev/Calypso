using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Calypso;

namespace Calypso
{
    public partial class CustomTaskbarShow : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x08000000;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_MOUSEACTIVATE = 0x0021;
            const int MA_NOACTIVATE = 3;

            if (m.Msg == WM_MOUSEACTIVATE)
            {
                m.Result = new IntPtr(MA_NOACTIVATE);
                return;
            }

            base.WndProc(ref m);
        }

        private readonly System.Windows.Forms.Timer syncTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();
        private readonly Dictionary<IntPtr, System.Windows.Forms.Panel> windowPanels = new Dictionary<IntPtr, System.Windows.Forms.Panel>();
        private IntPtr currentActiveHandle = IntPtr.Zero;
        private readonly HashSet<System.Windows.Forms.Panel> hoveredPanels = new HashSet<System.Windows.Forms.Panel>();
        private HashSet<IntPtr> previousWindowHandles = new HashSet<IntPtr>();

        public CustomTaskbarShow()
        {
            InitializeComponent();
        }

        private void CustomTaskbarShow_Load(object sender, EventArgs e)
        {
            WindowManager.HideTaskbar();
            this.Height = 40 * Screen.PrimaryScreen.Bounds.Height / 1080;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - this.Height);

            AddStartButton();
            SyncWindowPanels();
            previousWindowHandles = new HashSet<IntPtr>(WindowManager.GetOpenWindows().Select(w => w.Handle));
            UpdateActiveHighlight();

            syncTimer.Interval = 500;
            syncTimer.Tick += SyncIfWindowListChanged;
            syncTimer.Start();

            highlightTimer.Interval = 100;
            highlightTimer.Tick += (s, ev) => UpdateActiveHighlight();
            highlightTimer.Start();

            previewShowTimer.Interval = 200;
            previewShowTimer.Tick += PreviewShowTimer_Tick;

            previewHideTimer.Interval = 10;
            previewHideTimer.Tick += PreviewHideTimer_Tick;
        }


        private void SyncIfWindowListChanged(object sender, EventArgs e)
        {
            var windows = WindowManager.GetOpenWindows();
            var newHandles = new HashSet<IntPtr>(windows.Select(w => w.Handle));
            if (!newHandles.SetEquals(previousWindowHandles))
            {
                SyncWindowPanels();
                previousWindowHandles = newHandles;
            }
        }

        private void AddStartButton()
        {
            int panelSize = this.Height;
            int startBtnSize = panelSize * 50 / 100;
            int startBtnOffset = (panelSize - startBtnSize) / 2;

            var pnlStart = new Panel
            {
                Size = new Size(panelSize, panelSize),
                Location = new Point(0, 0),
                BorderStyle = BorderStyle.None,
                Tag = IntPtr.Zero
            };
            var btnStart = new PictureBox
            {
                Size = new Size(startBtnSize, startBtnSize),
                Location = new Point(startBtnOffset, startBtnOffset),
                BackgroundImage = Image.FromStream(new MemoryStream(CalypsoResources.WindowsIcon)),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btnStart.Click += (s, e) => Application.Restart();
            pnlStart.Controls.Add(btnStart);
            AttachHoverEvents(pnlStart);

            windowPanels[IntPtr.Zero] = pnlStart;
            this.Controls.Add(pnlStart);

            var searchKey = new IntPtr(1);
            int searchBtnSize = panelSize * 60 / 100;
            int searchBtnOffset = (panelSize - searchBtnSize) / 2;

            var pnlSearch = new Panel
            {
                Size = new Size(panelSize, panelSize),
                BorderStyle = BorderStyle.None,
                Tag = searchKey
            };
            var btnSearch = new PictureBox
            {
                Size = new Size(searchBtnSize, searchBtnSize),
                Location = new Point(searchBtnOffset, searchBtnOffset),
                BackgroundImage = Image.FromStream(new MemoryStream(CalypsoResources.SearchIcon)),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            btnSearch.Click += (s, e) => Application.Restart();
            pnlSearch.Controls.Add(btnSearch);
            AttachHoverEvents(pnlSearch);

            windowPanels[searchKey] = pnlSearch;
            this.Controls.Add(pnlSearch);
        }

        private void SyncWindowPanels()
        {
            var excludedPaths = new[]
            {
                @"C:\Windows\Explorer.EXE",
                @"C:\Windows\system32\ApplicationFrameHost.exe",
                @"C:\Windows\SystemApps\MicrosoftWindows.Client.CBS_cw5n1h2txyewy\TextInputHost.exe"
            };

            var windows = WindowManager.GetOpenWindows()
                .Where(w => !excludedPaths.Contains(w.ExecutablePath, StringComparer.OrdinalIgnoreCase))
                .ToList();

            var newHandles = new HashSet<IntPtr>(windows.Select(w => w.Handle));
            var searchKey = new IntPtr(1);

            var toRemove = windowPanels.Keys
                .Where(h => h != IntPtr.Zero && h != searchKey && !newHandles.Contains(h))
                .ToList();
            foreach (var h in toRemove)
                RemoveWindowPanel(h);

            foreach (var win in windows)
                if (!windowPanels.ContainsKey(win.Handle))
                    AddWindowPanel(win);

            LayoutPanels();
        }

        private void LayoutPanels()
        {
            if (windowPanels.TryGetValue(IntPtr.Zero, out var pnlStart))
                pnlStart.Location = new Point(0, 0);

            var searchKey = new IntPtr(1);
            if (windowPanels.TryGetValue(searchKey, out var pnlSearch))
                pnlSearch.Location = new Point(this.Height + 5, 0);

            int x = (this.Height + 5) * 2;
            foreach (var kv in windowPanels
                                 .Where(kv => kv.Key != IntPtr.Zero && kv.Key != searchKey)
                                 .OrderBy(kv => kv.Key.ToInt64()))
            {
                kv.Value.Location = new Point(x, 0);
                x += this.Height + 5;
            }
        }

        private void UpdateActiveHighlight()
        {
            IntPtr active = WindowManager.GetActiveWindowHandle();
            if (active == currentActiveHandle) return;

            if (windowPanels.TryGetValue(currentActiveHandle, out var prev))
                prev.BackColor = Color.Transparent;

            if (windowPanels.TryGetValue(active, out var curr))
                curr.BackColor = Color.FromArgb(25, 25, 25);

            currentActiveHandle = active;
        }

        private void AttachHoverEvents(Panel pnl)
        {
            var hoverColor = Color.FromArgb(50, 50, 50);
            var activeColor = Color.FromArgb(25, 25, 25);
            pnl.Click += (s, e) => WindowManager.ToggleWindow((IntPtr)pnl.Tag);
            foreach (Control ctl in pnl.Controls)
                ctl.Click += (s, e) => WindowManager.ToggleWindow((IntPtr)pnl.Tag);

            void Enter(object s, EventArgs e)
            {
                hoveredPanels.Add(pnl);
                pnl.BackColor = hoverColor;
                previewHideTimer.Stop();
                previewTargetPanel = pnl;
                previewShowTimer.Start();
            }

            void Leave(object s, EventArgs e)
            {
                var pt = pnl.PointToClient(Cursor.Position);
                if (pnl.ClientRectangle.Contains(pt))
                    return;

                hoveredPanels.Remove(pnl);
                pnl.BackColor = (pnl.Tag is IntPtr h && h == currentActiveHandle)
                    ? activeColor
                    : Color.Transparent;
                previewShowTimer.Stop();
                previewHideTimer.Start();
            }

            pnl.MouseEnter += Enter;
            pnl.MouseLeave += Leave;
            foreach (Control ctl in pnl.Controls)
            {
                ctl.MouseEnter += Enter;
                ctl.MouseLeave += Leave;
            }
        }

        private IntPtr lastPreviewHandle = IntPtr.Zero;

        private void PreviewShowTimer_Tick(object sender, EventArgs e)
        {
            previewShowTimer.Stop();

            if (previewTargetPanel == null)
                return;

            var handle = (IntPtr)previewTargetPanel.Tag;
            if (handle == IntPtr.Zero)
                return; 

            if (previewForm != null && handle == lastPreviewHandle)
                return;

            ShowPreviewForPanel(previewTargetPanel);
        }

        private void PreviewHideTimer_Tick(object sender, EventArgs e)
        {
            previewHideTimer.Stop();
            HidePreview();
        }

        private void ShowPreviewForPanel(Panel pnl)
        {
            HidePreview();

            var handle = (IntPtr)pnl.Tag;
            if (handle == IntPtr.Zero)
                return;

            int w = Screen.PrimaryScreen.Bounds.Width * 10 / 100;
            int h = Screen.PrimaryScreen.Bounds.Height * 10 / 100;
            var screenPos = pnl.PointToScreen(Point.Empty);
            int x = screenPos.X + pnl.Width / 2 - w / 2;
            int y = screenPos.Y - h;

            previewForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                ShowInTaskbar = false,
                TopMost = true,
                Size = new Size(w, h),
                Location = new Point(x, y),
                BackColor = Color.Black,
                Opacity = 0.9
            };

            var btnClose = new Button
            {
                Text = "✕",
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(24, 24),
                Location = new Point(w - 26, 2),
                BackColor = Color.FromArgb(25, 25, 25),
                ForeColor = Color.White
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) =>
            {
                var win = WindowManager.GetOpenWindows().FirstOrDefault(wi => wi.Handle == handle);
                if (win != null)
                    WindowManager.KillProcess(win.ProcessId);
                HidePreview();
            };
            previewForm.Controls.Add(btnClose);

            if (WindowManager.DwmRegisterThumbnail(previewForm.Handle, handle, out var thumb) == 0)
            {
                WindowManager.DwmQueryThumbnailSourceSize(thumb, out var srcSize);
                var props = new WindowManager.DWM_THUMBNAIL_PROPERTIES
                {
                    dwFlags = WindowManager.DWM_TNP_RECTDESTINATION | WindowManager.DWM_TNP_VISIBLE | WindowManager.DWM_TNP_OPACITY,
                    fVisible = true,
                    opacity = 255,
                    rcDestination = new WindowManager.RECT { Left = 0, Top = 0, Right = w, Bottom = h }
                };
                WindowManager.DwmUpdateThumbnailProperties(thumb, ref props);
                previewForm.FormClosed += (s, e) => WindowManager.DwmUnregisterThumbnail(thumb);
            }

            previewForm.MouseEnter += (s, e) => previewHideTimer.Stop();
            previewForm.MouseLeave += (s, e) =>
            {
                var pt = previewForm.PointToClient(Cursor.Position);
                if (!previewForm.ClientRectangle.Contains(pt))
                    previewHideTimer.Start();
            };

            previewForm.Show();
            lastPreviewHandle = handle;
        }

        private void HidePreview()
        {
            if (previewForm != null)
            {
                previewForm.Close();
                previewForm = null;
            }
            lastPreviewHandle = IntPtr.Zero;
        }

        private void AddWindowPanel(ManagedWindow win)
        {
            int btnSize = this.Height * 70 / 100;
            int btnOffset = (this.Height - btnSize) / 2;

            var pnl = new Panel
            {
                Size = new Size(this.Height, this.Height),
                BorderStyle = BorderStyle.None,
                Tag = win.Handle
            };
            var btn = new PictureBox
            {
                Size = new Size(btnSize, btnSize),
                Location = new Point(btnOffset, btnOffset)
            };
            if (win.Icon != null)
            {
                btn.Image = win.Icon.ToBitmap();
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pnl.Controls.Add(btn);
            AttachHoverEvents(pnl);

            windowPanels[win.Handle] = pnl;
            this.Controls.Add(pnl);
        }

        private void RemoveWindowPanel(IntPtr handle)
        {
            if (windowPanels.TryGetValue(handle, out var pnl))
            {
                this.Controls.Remove(pnl);
                pnl.Dispose();
                windowPanels.Remove(handle);
                if (currentActiveHandle == handle)
                    currentActiveHandle = IntPtr.Zero;
            }
        }

        private readonly System.Windows.Forms.Timer previewShowTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer previewHideTimer = new System.Windows.Forms.Timer();

        private Panel previewTargetPanel = null;
        private Form previewForm = null;

        private void CustomTaskbarShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowManager.ShowTaskbar();
        }
    }
}
