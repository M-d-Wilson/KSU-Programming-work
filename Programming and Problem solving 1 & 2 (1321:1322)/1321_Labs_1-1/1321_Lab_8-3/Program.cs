using System;

namespace _Lab_83
{
    class MainClass
    {
        static int reverse(int number)
        {
            int Reverse = 0, temp;
            while (number > 0)
            {
                temp = number % 10;
                Reverse += temp;
                number /= 10;
                Reverse *= 10;
            }
            Reverse /= 10;
            return Reverse;
        }

        static Boolean isPalindrome(int number)
        {
            int Reverse;
            Reverse = reverse(number);
            if (Reverse == number)
            {
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            int Num;
            Console.Write("Enter a number:  ");
            Num = Convert.ToInt32(Console.ReadLine());
             if (isPalindrome(Num))
            {
                Console.Write("Judgement:       Palindrome");
            }
            else
            {
                Console.Write("Judgement:       Not palindrome");
            }

        }
    }
}
