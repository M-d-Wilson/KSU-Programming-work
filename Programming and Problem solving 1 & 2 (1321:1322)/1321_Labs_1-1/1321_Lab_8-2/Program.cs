using System;

namespace _Lab_82
{
    class MainClass
    {
        static double squareArea(double X)
        {
            double Area;
            Area = X * X;
            return Area;
        }

        static double rectangleArea(double X, double Y)
        {
            double Area;
            Area = X * Y;
            return Area;
        }

        static double circleArea(double X)
        {
            double Area;
            Area = 3.14 * X * X;
            return Area;
        }

        static double triangleArea(double X, double Y)
        {
            double Area;
            Area = (X * Y) / 2;
            return Area;
        }

        public static void Main(string[] args)
        {
            double temp1, temp2;
            Console.Write("Square side:         ");
            temp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square Area          " + squareArea(temp1));
            Console.Write("Rectangle width:     ");
            temp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rectangle length:    ");
            temp2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rectangle area:      " + rectangleArea(temp1, temp2));
            Console.Write("Circle radius:       ");
            temp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Circle Area:         " + circleArea(temp1));
            Console.Write("Triangle bade:       ");
            temp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Triangle hight:      ");
            temp2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Triangle Area:       " + triangleArea(temp1, temp2));
        }
    }
}
