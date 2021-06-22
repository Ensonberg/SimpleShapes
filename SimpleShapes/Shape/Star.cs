using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimpleShapes.Shape
{
    public class Star:Shape
    {
        public void DrawStar(PaintEventArgs e)
        
        {
            System.Drawing.Rectangle myRectangle = new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            PointF[] pts = StarPoints(5, myRectangle);
            e.Graphics.DrawPolygon(this.Pen, pts);
            e.Graphics.FillPolygon(this.SolidBrush,pts);
        }
        private PointF[] StarPoints(int num_points, System.Drawing.Rectangle bounds)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];

            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }
        
    }
}