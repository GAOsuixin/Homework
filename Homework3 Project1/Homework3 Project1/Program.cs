using System;

namespace Homework3_Project1
{
    interface Shape
    {
        double Area();
        bool Legal();
    }
    class Triangle : Shape
    {
        public int length1 { set; get; }
        public int length2 { set; get; }
        public int length3 { set; get; }
        public Triangle(int a,int b,int c)
        {
            this.length1 = a;
            this.length2 = b;
            this.length3 = c;
        }
        public double Area()
        {
            double s = (length1 + length2 + length3) / 2;
            Double S = s * (s - length1) * (s - length2) * (s - length3);
            return Math.Sqrt(S);
        }
        public bool Legal()
        {

            if (length1 > 0 && length2 > 0 && length3 > 0 &&
                length1 + length2 > length3 && length1 + length3 > length2 && length2 + length3 > length1)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Rectangle : Shape
    {
        public int height { set; get; }
        public int width { set; get; }
        public Rectangle(int a, int b)
        {
            this.height = a;
            this.width = b;
        }
        public double Area()
        {
            return width * height;
        }
        public bool Legal()
        {
            if (height > 0 && width > 0)
            {
                return true;
            }
            else
                return false;
        }

    }
    class Square : Shape
    {
        public int length { set; get; }
        public Square(int a)
        {
            this.length = a;
        }
        public double Area()
        {
            return length*length;
        }
        public bool Legal()
        {
            if (length > 0)
            {
                return true;
               
            }
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("长和宽分别为4、2的矩形面积为" + new Rectangle(4, 2).Area());
            Console.WriteLine("边长为3的正方形的面积为 " + new Square(3).Area());
            Console.WriteLine("三边分别为3、4、5的三角形的面积为 " + new Triangle(3, 4,5).Area());
            System.Console.ReadKey();
        }
        
    }
}
