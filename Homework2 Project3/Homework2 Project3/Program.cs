﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace homework2_project3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(i + "是质数");
                    continue;
                }
                for (int j = 2; j <= (int)(Math.Sqrt(i)) + 1; j++)
                {
                    if (j == (int)(Math.Sqrt(i)) + 1 && (i % j != 0))
                    {
                        Console.WriteLine(i + "是质数");
                    }
                    else if (i % j == 0)
                    {
                        break;
                    }
                }
            }
            System.Console.ReadKey();
        }
    }
}
