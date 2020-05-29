using System;

namespace Homework3_Project2
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
        public Triangle(int a, int b, int c)
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
        public Rectangle(int d, int e)
        {
            this.height = d;
            this.width = e;
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
        public Square(int f)
        {
            this.length = f;
        }
        public double Area()
        {
            return length * length;
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
            int w = 0;
            double x = 0.0;
            do
            {
                Random rd = new Random();
                int i = rd.Next(1, 3);
                switch (i)
                {
                    case 1:
                        int a = rd.Next(1, 10);
                        int b = rd.Next(1, 10);
                        int c = rd.Next(1, 10);
                        Triangle t = new Triangle(a, b, c);
                        if (t.Legal() && t.Area() > 0)
                        {
                            Console.WriteLine("生成了一个面积为" + t.Area() + "的三角形");
                            w = w + 1;
                            x = x + t.Area();
                        }
                        else
                            w = w + 0;
                        break;
                    case 2:
                        int d = rd.Next(1, 10);
                        int e = rd.Next(1, 10);
                        Rectangle r = new Rectangle(d, e);
                        if (r.Legal() && r.Area() > 0)
                        {
                            Console.WriteLine("生成了一个面积为" + r.Area() + "的长方形");
                            w = w + 1;
                            x = x + r.Area();
                        }
                        else
                            w = w + 0;
                        break;
                    case 3:
                        int f = rd.Next(1, 10);
                        Square s = new Square(f);
                        if (s.Legal() && s.Area() > 0)
                        {
                            Console.WriteLine("生成了一个面积为" + s.Area() + "的正方形");
                            w = w + 1;
                            x = x + s.Area();
                        }
                        else
                            w = w + 0;
                        break;
                    default:
                        break;
                }

            } while (w < 10);
            Console.WriteLine("总面积为" + x);
            System.Console.ReadKey();
        }
    }
}