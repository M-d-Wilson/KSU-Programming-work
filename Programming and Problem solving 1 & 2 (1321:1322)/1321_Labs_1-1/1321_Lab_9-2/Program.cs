using System;

namespace _Lab_92
{
    class MainClass
    {
        static void printChars(char ch1, char ch2)
        {
            int i = 1;
            while (ch1 != ch2)
            {
                Console.Write(ch1 + " ");
                if((i % 5) == 0)
                {
                    Console.WriteLine();
                }
                i++;
                ch1++;
            }
            Console.Write(ch1 + " ");

        }

        public static void Main(string[] args)
        {
            char ch1, ch2;
            Console.Write("Starting charicter:  ");
            ch1 = Convert.ToChar(Console.ReadLine());
            Console.Write("End charicter:       ");
            ch2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Output: ");
            printChars(ch1, ch2);
        }
    }
}
