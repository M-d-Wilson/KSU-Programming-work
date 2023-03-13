using System;

namespace _Lab_31
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int X, Y, Z, avrage;
            Console.Write("X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Z: ");
            Z = Convert.ToInt32(Console.ReadLine());
            avrage = (X + Y + Z) / 3;
            Console.Write("Avrage: " + avrage);
        }
    }
}
