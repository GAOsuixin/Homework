﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            WriteLine("请输入数组的长度：");
            int length = Convert.ToInt32(Console.ReadLine());
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("请输入第{0}个数组的值：", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            WriteLine("其中的素数为：");
            for (int i = 0; i < length; i++)
            {
                int j = array[i];
                int sum = 0;
                for (int k = 1; k <= j; k++)
                {
                    if (j % k == 0)
                    {
                        sum = sum + 1;
                    }
                }
                if (sum == 2)
                {
                    Console.WriteLine(array[i]);
                }
            }
            System.Console.ReadKey();
        }
    }
}
