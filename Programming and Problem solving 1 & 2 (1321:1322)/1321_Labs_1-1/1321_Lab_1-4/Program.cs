using System;

namespace _Lab_14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int miles;
            double galons, mpg;
            Console.WriteLine("Enter a number of miles: ");
            miles = Convert.ToInt32(Console.Read());
            Console.WriteLine("Enter the gallons in miles: ");
            galons = Convert.ToInt32(Console.ReadLine());
            mpg = miles / galons;
            Console.Write("Miles Per Galon: " + mpg);
        }
    }
}
