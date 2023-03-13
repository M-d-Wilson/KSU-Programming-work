using System;

namespace _Lab_63
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int numb;
            Console.Write("Ten Random numbers: ");
            for (int i = 0; i <= 10; i++)
            {
                numb = rnd.Next(1, 50);
                Console.Write(numb);
                if(i != 10)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
