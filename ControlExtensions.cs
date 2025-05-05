using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Calypso
{
    public class ControlExtensions
    {
        public static void ApplyRoundedCorners(Control ctrl, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }

        public static void ApplyCustomRoundedCorners(Control ctrl, int topLeft, int topRight, int bottomRight, int bottomLeft)
        {
            Rectangle bounds = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            GraphicsPath path = new GraphicsPath();

            int tl = topLeft * 2;
            int tr = topRight * 2;
            int br = bottomRight * 2;
            int bl = bottomLeft * 2;

            path.StartFigure();
            if (topLeft > 0)
                path.AddArc(bounds.X, bounds.Y, tl, tl, 180, 90);
            else
                path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y);
            if (topRight > 0)
                path.AddArc(bounds.Right - tr, bounds.Y, tr, tr, 270, 90);
            else
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y);
            if (bottomRight > 0)
                path.AddArc(bounds.Right - br, bounds.Bottom - br, br, br, 0, 90);
            else
                path.AddLine(bounds.Right, bounds.Bottom, bounds.Right, bounds.Bottom);
            if (bottomLeft > 0)
                path.AddArc(bounds.X, bounds.Bottom - bl, bl, bl, 90, 90);
            else
                path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom);

            path.CloseFigure();

            ctrl.Region = new Region(path);
        }

        public static void DrawRoundedBorder(Control control, Graphics g, Color borderColor, int thickness, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int offsetRight = 2;
                int offsetBottom = 2;

                Rectangle rect = new Rectangle(
                    thickness / 2,
                    thickness / 2,
                    control.Width - thickness - offsetRight,
                    control.Height - thickness - offsetBottom
                );

                int arcSize = radius * 2;

                path.AddArc(rect.X, rect.Y, arcSize, arcSize, 180, 90);
                path.AddArc(rect.Right - arcSize, rect.Y, arcSize, arcSize, 270, 90);
                path.AddArc(rect.Right - arcSize, rect.Bottom - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(borderColor, thickness))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}
