using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleShapes.Shape;
using Rectangle = SimpleShapes.Shape.Rectangle;

namespace SimpleShapes
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black, 1);
         int x, y, height, width, x1, x2, y1, y2;
        SolidBrush solidBrush = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            


        }
        private void InitDrawingTools(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            myPen.DashStyle = DashStyle.Solid;
            myPen.Color = Color.Cyan;
            myPen.Width = 3;    
            solidBrush.Color = Color.Cyan;
            x = 10;
            y = 10;
            height = 200;
            width = 200;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        
        {
            
             InitDrawingTools(e);
            DrawPolyGon(e);
            DrawStar(e);
            DrawTriangle(e);
            
             DrawCircle(e);
             DrawRectangle(e);
             
            

       

        }

        private void DrawPolyGon(PaintEventArgs e)
        {
            var polygon = new Polygon();
            polygon.Height = 100;
            polygon.Width = 100;
            polygon.SolidBrush = new SolidBrush(color: Color.Red);
            polygon.Pen = new Pen(color: Color.Green, width: 3);
            polygon.DrawPolygon(e);
        }

        private void DrawRectangle(PaintEventArgs e)
        {
            var rectangle = new Rectangle();
            rectangle .X = 420;
            rectangle .Y = y;
            rectangle .Width =800;
            rectangle .Height = height;
            rectangle.Pen = new Pen(color: Color.Black, width: 3);
            rectangle .SolidBrush = new SolidBrush(color:Color.Blue);
            rectangle .DrawRectangle(e);
        }

        private void DrawStar(PaintEventArgs e)
        {
            var star = new Star();
            star .X = 20;
            star .Y = 200;
            star .Width =width;
            star .Height = height;
            star.SolidBrush = new SolidBrush(color: Color.Blue);
            star.Pen = new Pen(color: Color.Blue, width: 3);
            star.DrawStar(e);
        }

        private void DrawCircle(PaintEventArgs e)
        {
            var circle = new Circle();
            circle.X = x+200;
            circle.Y = 220;
            circle.Width =width;
            circle.Height = height;
            circle.Pen = new Pen(color:Color.Blue,width:3);
            circle.SolidBrush =new SolidBrush(color:Color.Yellow);
            circle.DrawCircle(e);
        }

        private void DrawTriangle(PaintEventArgs e)
        {
            var traingle = new Triangle();
            traingle .X = 200;
            traingle .Y = y;
            traingle .Width =width;
            traingle .Height = height;
            traingle.Pen = new Pen(color: Color.Green, width: 3);
            traingle .SolidBrush = new SolidBrush(color:Color.Green);
            traingle .DrawTriangle(e);


          
        }

    }
}