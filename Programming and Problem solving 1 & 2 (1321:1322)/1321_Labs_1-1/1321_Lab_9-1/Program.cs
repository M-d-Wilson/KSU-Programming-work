using System;

namespace _Lab_91
{
    class MainClass
    {
        static int sumDigits(int number)
        {
            int sum = 0, temp;
            while(number > 0)
            {
                temp = number % 10;
                sum += temp;
                number /= 10;
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:  ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum of digits:	" + sumDigits(num));
        }
    }
}
