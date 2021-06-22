using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimpleShapes.Shape
{
    public class Triangle:Shape
    {
        public void DrawTriangle(PaintEventArgs e)
        
        {
            System.Drawing.Rectangle myRectangle = new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = CreatePath( myRectangle);
            e.Graphics.DrawPolygon(this.Pen, path.PathPoints);
            e.Graphics.FillPolygon(this.SolidBrush,path.PathPoints);
        }
        public  GraphicsPath CreatePath(System.Drawing.Rectangle bounds)
        {
            GraphicsPath path = new GraphicsPath();
 
            Point top = new Point(bounds.X + bounds.Width / 2, bounds.Y);
            Point right = new Point(bounds.X + bounds.Width, bounds.Y + bounds.Height);
            Point left = new Point(bounds.X, bounds.Y + bounds.Height);
         
            path.AddPolygon(new Point[]
            {
                top,
                right,
                left
            });
            return path;
        }
    }
}