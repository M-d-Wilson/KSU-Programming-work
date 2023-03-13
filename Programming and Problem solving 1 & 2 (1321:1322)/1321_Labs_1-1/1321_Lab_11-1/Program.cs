using System;

namespace _Lab_111
{
    class Circle
    {
        private double radious, X;

        public Circle()
        {
            radious = 1;
        }

        public Circle(double R)
        {
            setRadious(R);
            radious = getRadious();
        }

        public double getRadious()
        {
            return radious;
        }

        public void setRadious(double R)
        {
            radious = R;
        }

        public double getArea()
        {
            X = 3.14 * (radious * radious);
            return X;
        }

        public double getPerimeter()
        {
            X = 3.14 * (radious) * 2;
            return X;
        }

        public void toString()
        {
            Console.Write("Print Radious: \n     The radious is " + getRadious() + ". \n" +
                          "Print Area: \n     The area is " + getArea() + ". \n" +
                          "Print Perimiter: \n     The perimiter is " + getPerimeter() + ". \n");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            double R;
            Circle C1 = new Circle();
            C1.toString();
            Console.Write("What is the radious of Circle: ");
            R = Convert.ToDouble(Console.ReadLine());
            Circle C2 = new Circle(R);
            C2.toString();
        }
    }
}
