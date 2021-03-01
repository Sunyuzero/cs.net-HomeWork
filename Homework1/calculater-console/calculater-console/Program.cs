using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculater_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("请输入两个操作数： ");
            String[] strs = Console.ReadLine().Split(' ');
            num1 = double.Parse(strs[0]);
            num2 = double.Parse(strs[1]);
            Console.Write("请输入操作符：");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '+':
                    Console.WriteLine("结果为：{0}", num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("结果为：{0}", num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("结果为：{0}", num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("结果为：{0}", num1 / num2);
                    break;
                default:
                    Console.WriteLine("不支持此操作符");
                    break;
            }
            Console.ReadLine();
        }
    }
}
