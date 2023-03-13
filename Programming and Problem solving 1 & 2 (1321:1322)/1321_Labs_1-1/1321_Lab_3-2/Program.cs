using System;

namespace _Lab_32
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double R, T, solution;
            Console.Write("R: ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("T: ");
            T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("R + T: " + (R + T));
            Console.WriteLine("R - T: " + (R - T));
            Console.WriteLine("R * T: " + (R * T));

        }
    }
}
