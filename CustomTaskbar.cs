using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Calypso
{
    public partial class CustomTaskbar : Form
    {
        public CustomTaskbar()
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
        }

        private void CustomTaskbar_Load(object sender, EventArgs e)
        {
            var taskbarpos = TaskbarInfo.GetTaskbarInfo();
            if(taskbarpos.position != TaskbarInfo.TaskbarPosition.Bottom)
            {
                WarnUser warn = new WarnUser("Not yet ready for use in positions other than bottom");
                warn.Show();
                return;
            }
            CustomTaskbarShow customTaskbarShow = new CustomTaskbarShow();
            customTaskbarShow.Show();
        }
    }
}
