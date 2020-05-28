using System;
using static System.Console;
namespace Calculator
{
    class Program
    {
        static void Main()
        {
            int a, b;
            double c = 0;
            char sign;
            WriteLine("请输入第一个数字");
            a = Int32.Parse(ReadLine() ?? throw new InvalidOperationException());
            WriteLine("请输入第二个数字");
            b = Int32.Parse(ReadLine() ?? throw new InvalidOperationException());
            WriteLine("请输入符号");
            sign = Char.Parse(ReadLine() ?? throw new InvalidOperationException());
            switch (sign)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
                default:
                    Console.WriteLine("请输入一个符号");
                    break;
            }
            Console.WriteLine(c.ToString());
            System.Console.ReadKey();
        }
    }
}


