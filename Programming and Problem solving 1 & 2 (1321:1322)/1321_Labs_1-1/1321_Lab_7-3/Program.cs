using System;

namespace _Lab_73
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int square, i, j;
            char simbol;
            Console.Write("What size square: ");
            square = Convert.ToInt32(Console.ReadLine());
            Console.Write("What simbol: ");
            simbol = Convert.ToChar(Console.ReadLine());
            for (i = 0; i < square; i++)
            {
                for (j = 0; j < square; j++)
                {
                    Console.Write(simbol);
                }
                Console.WriteLine();
            }
        }
    }
}
