using System;

namespace _Lab_61
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int value, totoal = 0, count = 0;
            Console.Write("Enter a value between 1 and 100: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered:     " + value);
            if (value < 1 || value > 100)
            {
                Console.WriteLine("Invalid input. Try again.");
            }
            else
            {
                while( value >= count)
                {
                    totoal += count;
                    count++;
                }
                Console.Write("Sum of values:   " + totoal);
            }


        }
    }
}
