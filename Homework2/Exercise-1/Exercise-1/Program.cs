using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.Write("请输入一个数字: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0}的所有素因数为： ",n);
            for (int i = 2; i <= n; i++)
            {
                if (n % i != 0) continue;
                if (isPrime(i)) Console.Write("{0} ", i);
            }
            Console.ReadLine();
        }
        static bool isPrime(int x)
        {
            if (x == 2) return true;
            for (int i = (int)Math.Sqrt(x) + 1; i >= 2; i--)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
