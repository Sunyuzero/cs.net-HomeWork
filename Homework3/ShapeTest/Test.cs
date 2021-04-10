using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Test
    {
        static double getRandomArea(String[] shapes)
        {
            int random = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0)).Next(0, 3);           
            Shape shape = new Factory().makeShape(shapes[random]);
            double area = shape.getArea();
            if (shape.islegal())
            {
                Console.WriteLine($"生成了{shapes[random]}，面积为：{area}");
                return shape.getArea();
            }
            Console.WriteLine($"生成的{shapes[random]}不合法，不计入面积和");
            return 0;
        }
        static void Main(String[] args)
        {
            String[] shapes = { "square", "rectangle", "triangle" };
            double ans = 0.0;
            for (int i = 1; i <= 10; i++)
            {
                ans += getRandomArea(shapes);
            }
            Console.WriteLine($"总面积为：{ans}");
            Console.ReadLine();
        }
    }
}
