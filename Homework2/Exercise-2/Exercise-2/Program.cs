using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数组的所有值：");
            String str = Console.ReadLine();
            String[] strs = str.Split(' ');
            int len = strs.Length;
            int[] a = new int[len];
            int max = int.Parse(strs[0]), min = int.Parse(strs[0]), ans = 0;
            for(int i = 0; i < len; i++)
            {
                a[i] = int.Parse(strs[i]);
                if (max < a[i]) max = a[i];
                if (min > a[i]) min = a[i];
                ans += a[i];
            }
            Console.WriteLine("最大值为:{0}，最小值为{1}，平均数为{2}，数组元素和为{3}：", max, min, (double) ans/len, ans);
            Console.ReadLine();
        }
    }
}
