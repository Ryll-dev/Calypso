using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

public class DragFormHelper
{
    private Control targetForm;
    private List<Control> dragControls;
    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HT_CAPTION = 0x2;

    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    public DragFormHelper(Control form)
    {
        targetForm = form;
        dragControls = new List<Control> { form };
        dragControls.AddRange(form.Controls.OfType<System.Windows.Forms.Panel>());
        dragControls.AddRange(form.Controls.OfType<Label>());
        dragControls.AddRange(form.Controls.OfType<PictureBox>());
        dragControls.AddRange(form.Controls.OfType<RichTextBox>());
        dragControls.AddRange(form.Controls.OfType<MetroListBox>());
        dragControls.AddRange(form.Controls.OfType<CircleProgressBar>());
        foreach (var panel in form.Controls.OfType<System.Windows.Forms.Panel>())
        {
            dragControls.AddRange(panel.Controls.OfType<Label>());
        }
        foreach (var panel in form.Controls.OfType<System.Windows.Forms.Panel>())
        {
            dragControls.AddRange(panel.Controls.OfType<System.Windows.Forms.Panel>());
        }
        foreach (var panel in form.Controls.OfType<System.Windows.Forms.Panel>())
        {
            dragControls.AddRange(panel.Controls.OfType<PictureBox>());
        }
        foreach (var panel in form.Controls.OfType<System.Windows.Forms.Panel>())
        {
            dragControls.AddRange(panel.Controls.OfType<RichTextBox>());
        }
        foreach (var panel in form.Controls.OfType<System.Windows.Forms.Panel>())
        {
            dragControls.AddRange(panel.Controls.OfType<MetroListBox>());
        }
        foreach (var panel in form.Controls.OfType<System.Windows.Forms.Panel>())
        {
            dragControls.AddRange(panel.Controls.OfType<CircleProgressBar>());
        }
        foreach (var ctrl in dragControls)
        {
            ctrl.MouseDown += DragControl_MouseDown;
        }
    }

    private void DragControl_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(targetForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    public void Detach()
    {
        foreach (var ctrl in dragControls)
        {
            ctrl.MouseDown -= DragControl_MouseDown;
        }
    }
}
