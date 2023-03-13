using System;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Lab 2

namespace _Milo_Lab1BClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person P1 = new Person();
            string first, last;
            Console.Write("What is your person's first name: ");
            first = Console.ReadLine();
            Console.Write("What is your person's last name: ");
            last = Console.ReadLine();
            Person P2 = new Person(first, last);
            P1.ToString();
            P2.ToString();
            P1.First = "Aly";
            P2.Last = "Sanchez";
            P1.ToString();
            P2.ToString();
        }
    }
}