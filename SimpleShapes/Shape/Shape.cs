using System.Drawing;

namespace SimpleShapes.Shape
{
    public class Shape
    {
        private int x1;
        private int x2;
        private int x;
        private int y1;
        private int y2;
        private int y;
        private int height;
        private int width;
        private Pen pen;
        private SolidBrush solidBrush;
        
        public SolidBrush SolidBrush
        {
            get;
            set;
        }
        public Pen Pen
        {
            get;
            set;
        }
        public int X1
        {
            get;
            set;
        }

        public int X2
        {
            get;
            set;
        }

        public int X
        {
            get;
            set;
        }

        public int Y1
        {
            get;
            set;
        }

        public int Y2
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }


        public Shape()
        {
            
        }

        public Shape(Shape shape)
        {
            shape.x = x;
            shape.y = y;
            shape.height = height;
            shape.width = width;
        }
    }
}