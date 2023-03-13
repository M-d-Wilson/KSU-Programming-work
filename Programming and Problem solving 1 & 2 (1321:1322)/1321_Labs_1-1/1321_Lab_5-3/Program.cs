using System;

namespace _Lab_53
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int X, Y;
            Console.Write("What is your X: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your Y: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("(" + X + ", " + Y + ") is ");
            if (X == 0 && Y == 0)
            {
                Console.Write("on the origin point");
            }
            else if (Y == 0)
            {
                Console.Write("on the Y axis");
            }
            else if (X == 0)
            {
                Console.Write("on the X axis");
            }
            else if (Y > 0 && X > 0)
            {
                Console.Write("in the first quadrent");
            }
            else if (Y > 0 && X < 0)
            {
                Console.Write("in the second quadrent");
            }
            else if (Y < 0 && X < 0)
            {
                Console.Write("in the third quadrent");
            }
            else if (Y < 0 && X > 0)
            {
                Console.Write("in the fourth quadrent");
            }
        }
    }
}
