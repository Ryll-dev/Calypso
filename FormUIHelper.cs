using System.Reflection.Metadata;
using ReaLTaiizor.Controls;
using Calypso;

public static class FormUIHelper
{
    public static void ApplyUI(Form form, bool transparent, bool autominimize, bool draghelper, bool setradiusform, bool setradius, bool Animation, ContentAlignment direction)
    {
        WindowManager.ForceActivate(form.Handle);
        if (transparent)
        {
            ApplyTransparencyEvents(form);
        }
        if (autominimize)
        {
            ApplyAutoMinimizeOnBlur(form);
            form.Opacity = 0.9;
            form.StartPosition = FormStartPosition.CenterScreen;
        }
        if(draghelper)
        {
            new DragFormHelper(form);
        }
        if(setradiusform)
        {
            ControlExtensions.ApplyRoundedCorners(form, 5);
        }
        if (setradius) 
        {
            ApplyRadiusToControl(form);
        }
        if (Animation)
        {
            if (direction == ContentAlignment.MiddleCenter)
            {
                ApplyOpenAnimationCenter(form);
                AttachCloseAnimationCenter(form);
            }
            else if (direction == ContentAlignment.TopCenter)
            {

            }
            else if (direction == ContentAlignment.TopLeft)
            {
                ApplyOpenAnimationHorizontalCenter(form);
                AttachCloseAnimationHorizontalCenter(form);
            }
        }
    }

    private static void ApplyOpenAnimationCenter(Form form)
    {
        form.StartPosition = FormStartPosition.Manual;
        Rectangle originalBounds = Rectangle.Empty;
        form.Load += (s, e) =>
        {
            var screen = Screen.FromControl(form).WorkingArea;
            originalBounds = new Rectangle(
                screen.X + (screen.Width - form.Width) / 2,
                screen.Y + (screen.Height - form.Height) / 2,
                form.Width,
                form.Height);

            form.Bounds = new Rectangle(
                originalBounds.X + originalBounds.Width / 2,
                originalBounds.Y + originalBounds.Height / 2,
                1,
                1);
        };
        form.Shown += async (s, e) =>
        {
            int steps = 30;
            for (int i = 1; i <= steps; i++)
            {
                float t = i / (float)steps;
                int w = (int)(1 + (originalBounds.Width - 1) * t);
                int h = (int)(1 + (originalBounds.Height - 1) * t);
                int x = originalBounds.X + (originalBounds.Width - w) / 2;
                int y = originalBounds.Y + (originalBounds.Height - h) / 2;
                form.Bounds = new Rectangle(x, y, w, h);

                await Task.Delay(5);
            }
            form.Bounds = originalBounds;
        };
    }


    private static void ApplyOpenAnimationHorizontalCenter(Form form)
    {
        form.StartPosition = FormStartPosition.Manual;
        Rectangle originalBounds = Rectangle.Empty;

        form.Load += (s, e) =>
        {
            var screen = Screen.FromControl(form).WorkingArea;
            originalBounds = new Rectangle(
                screen.X + (screen.Width - form.Width) / 2,
                screen.Y + (screen.Height - form.Height) / 2,
                form.Width,
                form.Height);
            form.Bounds = new Rectangle(
                originalBounds.X + originalBounds.Width / 2,
                originalBounds.Y,
                1,
                originalBounds.Height);
        };

        form.Shown += async (s, e) =>
        {
            const int steps = 30;
            for (int i = 1; i <= steps; i++)
            {
                float t = i / (float)steps;
                int w = (int)(1 + (originalBounds.Width - 1) * t);
                int h = originalBounds.Height;

                int x = originalBounds.X + (originalBounds.Width - w) / 2;
                int y = originalBounds.Y;

                form.Bounds = new Rectangle(x, y, w, h);
                await Task.Delay(5);
            }
            form.Bounds = originalBounds;
        };
    }



    private static void AttachCloseAnimationCenter(Form form)
    {
        bool animating = false;
        FormClosingEventHandler handler = null;
        handler = async (s, e) =>
        {
            if (animating) return;
            animating = true;
            e.Cancel = true;
            int centerX = form.Left + form.Width / 2;
            int centerY = form.Top + form.Height / 2;

            int steps = 30;
            for (int i = 0; i < steps; i++)
            {
                int newW = (int)(form.Width * 0.9);
                int newH = (int)(form.Height * 0.9);
                form.Width = newW;
                form.Height = newH;
                form.Left = centerX - newW / 2;
                form.Top = centerY - newH / 2;

                await Task.Delay(5);
            }
            form.FormClosing -= handler;
            form.Close();
            form.Hide();
        };

        form.FormClosing += handler;
    }

    private static void AttachCloseAnimationHorizontalCenter(Form form)
    {
        bool animating = false;
        FormClosingEventHandler handler = null;
        handler = async (s, e) =>
        {
            if (animating) return;
            animating = true;
            e.Cancel = true;
            var originalBounds = new Rectangle(form.Left, form.Top, form.Width, form.Height);

            const int steps = 30;
            for (int i = 1; i <= steps; i++)
            {
                float t = i / (float)steps;
                int w = (int)(originalBounds.Width - (originalBounds.Width - 1) * t);
                int h = originalBounds.Height;
                int x = originalBounds.X + (originalBounds.Width - w) / 2;
                int y = originalBounds.Y;

                form.Bounds = new Rectangle(x, y, w, h);

                await Task.Delay(5);
            }
            form.FormClosing -= handler;
            form.Close();
        };

        form.FormClosing += handler;
    }


    private static void ApplyRadiusToControl(Control parent)
    {
        foreach (Control ctrl in parent.Controls)
        {
            if (ctrl is RichTextBox || ctrl is ForeverComboBox)
            {
                ControlExtensions.ApplyRoundedCorners(ctrl, 10 * ctrl.Height / 100);
            }
            else if (ctrl is ForeverTextBox ftb)
            {
                ControlExtensions.ApplyRoundedCorners(ctrl, 30 * ctrl.Height / 100);
                ftb.BorderColor = ftb.BaseColor;
            }
            else if (ctrl is MetroListBox metrolistbox)
            {
                ControlExtensions.ApplyRoundedCorners(ctrl, 3 * ctrl.Height / 100);
                Color backColor = Color.FromArgb(25, 25, 25);
                Color foreColor = Color.FromArgb(180, 180, 180);
                Color hoveredBack = Color.FromArgb(30, 30, 30);
                Color hoveredFore = Color.FromArgb(180, 180, 180);
                metrolistbox.BackColor = backColor;
                metrolistbox.ForeColor = foreColor;
                metrolistbox.HoveredItemBackColor = hoveredBack;
                metrolistbox.HoveredItemColor = hoveredFore;
                metrolistbox.SelectedItemBackColor = hoveredBack;
                metrolistbox.SelectedItemColor = hoveredFore;
            }
            else if (ctrl is LostButton)
            {
                ControlExtensions.ApplyRoundedCorners(ctrl, 40 * ctrl.Height / 100);
            }
            else if (ctrl is System.Windows.Forms.Panel panel)
            {
                panel.Paint += (s, e) =>
                {
                    ControlExtensions.DrawRoundedBorder(panel, e.Graphics, Color.FromArgb(180, 180, 180), 1, 5);
                };
            }
            if (ctrl.HasChildren)
            {
                ApplyRadiusToControl(ctrl);
            }
        }
    }

    private static void ApplyAutoMinimizeOnBlur(Form form)
    {
        form.Deactivate += (s, e) =>
        {
            if (form.WindowState != FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        };
    }

    private static void ApplyTransparencyEvents(Form form)
    {
        void SetOpacity(bool hovered)
        {
            form.Opacity = hovered ? 1.0 : 0.9;
        }

        void AddMouseEventsRecursively(Control ctrl)
        {
            ctrl.MouseEnter += (s, e) => SetOpacity(true);
            ctrl.MouseLeave += (s, e) =>
            {
                if (!form.Bounds.Contains(Cursor.Position))
                {
                    SetOpacity(false);
                }
            };

            foreach (Control child in ctrl.Controls)
            {
                AddMouseEventsRecursively(child);
            }
        }

        AddMouseEventsRecursively(form);
    }
}
