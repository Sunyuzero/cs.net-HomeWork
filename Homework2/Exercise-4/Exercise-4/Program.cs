using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入矩阵的行数和列数：");
            String str = Console.ReadLine();
            String[] strs = str.Split(' ');
            try
            {
                int row = int.Parse(strs[0]), col = int.Parse(strs[1]);
                int[,] a = new int[row , col];
                for (int i = 0; i < row; i++)
                {
                    String num = Console.ReadLine();
                    String[] nums = num.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        a[i, j] = int.Parse(nums[j]);
                    }
                }
                if (isTrueMatrix(row, col, a)) Console.WriteLine("true");
                else Console.WriteLine("false");
            }
            catch(FormatException e)
            {
                Console.WriteLine("必须输入数字");
            }
            Console.ReadLine();
        }
        static bool isTrueMatrix(int row , int col , int[,] matrix)
        {
            if (row == 0 && col == 0) return false;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if (matrix[i,j] != matrix[i + 1,j + 1]) return false;
                }
            }
            return true;
        }
    }
}
