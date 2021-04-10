using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Factory
    {
        public Shape makeShape(String shape)
        {
            double r1 = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(1, 100);
            double r2 = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(1, 100);
            double r3 = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(1, 100);

            if (shape.Equals("square", StringComparison.InvariantCultureIgnoreCase))
                return new Square(r1);
            else if (shape.Equals("rectangle", StringComparison.InvariantCultureIgnoreCase))
                return new Rectangle(r1, r2);
            else if (shape.Equals("triangle", StringComparison.InvariantCultureIgnoreCase))
                return new Triangle(r1, r2, r3);
            else
                return null;
        }
    }
}
