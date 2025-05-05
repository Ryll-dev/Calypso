using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace Calypso
{
    public partial class WarnUser : Form
    {
        private string _warn;
        public WarnUser(string warn)
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
            _warn = warn;
            rtxtALERT.MouseDown += (s, e) => HideCaret(rtxtALERT.Handle);
            rtxtALERT.GotFocus += (s, e) => HideCaret(rtxtALERT.Handle);
            rtxtALERT.SelectionChanged += (s, e) => HideCaret(rtxtALERT.Handle);
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private async void WarnUser_Load(object sender, EventArgs e)
        {
            rtxtALERT.Text = _warn;
            await Task.Delay(10);
            HideCaret(rtxtALERT.Handle);
        }

        private void WarnUser_Shown(object sender, EventArgs e)
        {
            HideCaret(rtxtALERT.Handle);
        }
    }
}
