using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleShapes.Shape
{
    public class Polygon:Shape
    {
        private float size_scale =
            (float)(1.0 / (2.0 * (1 + Math.Cos(Math.PI/180*72))));
        public void DrawPolygon(PaintEventArgs e)
        {
            int depth = 0;
            PointF center = new PointF(
                this.Width ,
                this.Height );
            float radius = (float)Math.Min(center.X,  center.Y);
            DrawPentagon(depth, e.Graphics, this.SolidBrush, center, radius);
          
        }
        private PointF[] GetPentagonPoints(PointF center, float radius)
        {
            PointF[] points = new PointF[5];
            double theta = -Math.PI / 2.0;
            double dtheta = 2.0 * Math.PI / 5.0;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(
                    center.X + (float)(radius * Math.Cos(theta)),
                    center.Y + (float)(radius * Math.Sin(theta)));
                theta += dtheta;
            }
            return points;
        }
        

// Draw a sierpinski pentagon.
        private void DrawPentagon(int depth,
            Graphics gr, Brush brush,
            PointF center, float radius)
        {
            // If we are done recursing, draw the pentagon.
            if (depth <= 0)
            {
                // Find the pentagon's corners.
                PointF[] points = GetPentagonPoints(center, radius);
                gr.FillPolygon(brush, points);
            }
            else
            {
                // Find the smaller pentagons' centers.
                float d = radius - radius * size_scale;
                PointF[] centers = GetPentagonPoints(center, d);

                // Recursively draw the smaller pentagons.
                foreach (PointF point in centers)
                {
                    DrawPentagon(depth - 1, gr, brush, point,
                        radius * size_scale);
                }
            }
        }
    }
}