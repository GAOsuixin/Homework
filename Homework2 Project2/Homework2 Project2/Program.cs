﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int i;
            double sum = 0.0;
            double average = 0.0;
            Console.WriteLine("请输入数组的长度：");
            int length = Convert.ToInt32(Console.ReadLine());
            array = new int[length];
            for (i = 0; i < length; i++)
            {
                Console.Write("请输入第{0}个数组的值：", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = array[0];
            int min = array[0];
            for (i = 0; i < length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
                if (array[i] <= min)
                {
                    min = array[i];
                }
                sum = sum + array[i];
            }
            average = sum / length;
            Console.WriteLine("数组的最大值为：" + max);
            Console.WriteLine("数组的最小值为：" + min);
            Console.WriteLine("数组的平均值为：" + average);
            Console.WriteLine("数组所有元素的和为：" + sum);
            System.Console.ReadKey();
        }
    }
}
