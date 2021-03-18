using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericityTest
{
    class Test
    {
        static void Main(String[] args)
        {
            GenericList<int> nodes = new GenericList<int>();
            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                nodes.Add(r.Next(0,100));
            }
            int ans = 0, max = -1, min = 101;
            Console.WriteLine("链表的元素为：");
            Node<int>.Each(nodes , m => Console.Write(m+" "));
            Console.WriteLine();
            Node<int>.Each(nodes , m => ans += m);
            Console.WriteLine($"和为：{ans}");
            Node<int>.Each(nodes , m => min = Math.Min(min, m));
            Console.WriteLine($"最小值为：{min}");
            Node<int>.Each(nodes , m => max = Math.Max(max, m));
            Console.WriteLine($"最大值为：{max}");          
            Console.ReadLine();
        }
    }
}
