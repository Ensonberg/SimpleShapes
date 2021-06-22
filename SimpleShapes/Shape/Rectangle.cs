using System.Drawing;
using System.Windows.Forms;

namespace SimpleShapes.Shape
{
    public class Rectangle:Shape
    {
        public void DrawRectangle(PaintEventArgs e)
        {
            System.Drawing.Rectangle myRectangle = new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);
           e.Graphics.DrawRectangle(this.Pen, myRectangle);  
            e.Graphics.FillRectangle(this.SolidBrush, myRectangle);
           // e.Graphics.DrawPie(this.Pen, myRectangle, 0, 180);
          
             
           // Draw polygon to screen.
        
           
           
        }

        public Rectangle()
        {
            
        }
    }
}