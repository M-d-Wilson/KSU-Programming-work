using System;

namespace _Lab_13
{
    class Echo
    {
        public static void Main(string[] args)
        {
            string message;
            Console.WriteLine("Enter a line of text.");
            message = Console.ReadLine();
            Console.WriteLine("You wrote \"" + message + "\"");
        }
    }
}
