using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side;
        }
        public double Side
        {
            get => side;
            set => side = value;
        }
        public double getArea()
        {
            if (side <= 0) return -1;
            return side * side;
        }

        public bool islegal()
        {
            return side > 0 ? true : false;
        }
    }
}
