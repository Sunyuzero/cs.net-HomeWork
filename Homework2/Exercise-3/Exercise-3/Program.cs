using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = new bool[101];
            for(int i = 0; i <= 100; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = isPrime[1] = false;
            int[] prime = new int[50];
            int top = -1;
            for(int i = 2; i <= 100; i++)
            {
                if (isPrime[i])
                {
                    prime[++top] = i;
                    for(int j = i * 2; j <= 100; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            Console.Write("100以内的素数有：");
            for(int i = 0 ; i <= top; i ++ )
            {
                Console.Write("{0} ", prime[i]);
            }
            Console.ReadLine();
        }
    }
}
