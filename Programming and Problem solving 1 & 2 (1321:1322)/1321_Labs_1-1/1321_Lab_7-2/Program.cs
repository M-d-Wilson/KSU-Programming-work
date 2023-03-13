using System;

namespace _Lab_72
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numb, count = 0, totat = 0;
            Console.Write("Give me a number: ");
            numb = Convert.ToInt32(Console.ReadLine());
            while (numb >= count)
            {
                if ((count % 2) == 0)
                {
                    totat += count;
                }
                count++;
            }
            Console.WriteLine("Entered value: " + numb);
            Console.WriteLine("Sum of even numbers between 2 and " + numb + " is " + totat);
        }
    }
}
