using System;

namespace _Lab_81
{
    class MainClass
    {
        static int Max(int X, int Y, int Z)
        {
            int max = X;
            if (Y > max)
            {
                max = Y;
            }
            if (Z > max)
            {
                max = Z;
            }
            return max;
        }

        static int Min(int X, int Y, int Z)
        {
            int min = X;
            if (Y < min)
            {
                min = Y;
            }
            if (Z < min)
            {
                min = Z;
            }
            return min;
        }

        static int Avrage(int X, int Y, int Z)
        {
            int avr;
            avr = (X + Y + Z) / 3;
            return avr;
        }

        public static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter number one:    ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number two:    ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number three:  ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered:     " + num1 + ", " + num2 + ", " + num3);
            Console.WriteLine("Max value:       " + Max(num1, num2, num3));
            Console.WriteLine("Min value:       " + Min(num1, num2, num3));
            Console.WriteLine("Avrage value:    " + Avrage(num1, num2, num3));

        }
    }
}
