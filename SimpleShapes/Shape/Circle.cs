using System.Drawing;
using System.Windows.Forms;

namespace SimpleShapes.Shape
{
    public class Circle : Shape
    {
       

        public void DrawCircle(PaintEventArgs e)
        {
           // e.Graphics.DrawLine(new Pen(Color.Salmon), 50, 30, 40, 100);
            //SolidBrush sb = new SolidBrush(Color.Red);  
            System.Drawing.Rectangle myRectangle = new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);
            e.Graphics.DrawEllipse(this.Pen, myRectangle);
             // e.Graphics.DrawEllipse(new Pen(Color.Salmon),  X - 50, Y - 50, 100, 100);  
              e.Graphics.FillEllipse(this.SolidBrush, myRectangle);    
        }


        
    }
}