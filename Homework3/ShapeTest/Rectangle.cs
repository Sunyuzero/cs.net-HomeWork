using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Rectangle : Shape
    {
        private double height, width;
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }
        public double getArea()
        {
            if (height < 0 || width <= 0) return -1;
            return height * width;
        }

        public bool islegal()
        {
            return height > 0 && width > 0 ? true : false;
        }
    }
}
