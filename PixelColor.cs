using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calypso
{
    public partial class PixelColor : Form
    {
        public PixelColor()
        {
            InitializeComponent();
            this.Shown += async (sender, e) => await GetPixel();
            FormUIHelper.ApplyUI(this, true, true, true, true, false,true, ContentAlignment.TopLeft);
        }

        private async Task GetPixel()
        {
            while (true)
            {
                Point mousePos = Control.MousePosition;
                Point pixelPos = new Point(mousePos.X, mousePos.Y + 20);
                Rectangle captureRect = new Rectangle(pixelPos.X - 50, pixelPos.Y - 50, 100, 100);
                using (Bitmap bmp = new Bitmap(1, 1))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(pixelPos, new Point(0, 0), new Size(1, 1));
                    }
                    Color color = bmp.GetPixel(0, 0);
                    lblRGBVALUE.Text = $"{color.R}, {color.G}, {color.B}";
                    lblHEXVALUE.Text = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
                    lblPOSVALUE.Text = $"{mousePos.X}x{mousePos.Y}";
                    pnlCOLOR.BackColor = color;
                }
                using (Bitmap bmp = new Bitmap(captureRect.Width, captureRect.Height))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(captureRect.Location, Point.Empty, captureRect.Size);
                    }
                    if (imgLIVESCREEN.Image != null)
                    {
                        imgLIVESCREEN.Image.Dispose();
                    }
                    imgLIVESCREEN.Image = (Bitmap)bmp.Clone();
                }
                await Task.Delay(10);
            }
        }
    }
}
