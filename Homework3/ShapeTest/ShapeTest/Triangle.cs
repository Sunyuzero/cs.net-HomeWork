using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Triangle : Shape
    {
        private double a, b, c, p;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            p = (a + b + c) / 2;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double getArea()
        {
            if (!islegal()) return -1;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool islegal()
        {
            if (a + b < c || a + c < b || b + c < a || a <= 0 || b <= 0 || c <= 0) return false;
            return true;
        }
    }
}
