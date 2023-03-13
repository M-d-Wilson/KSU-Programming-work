using System;

namespace _Lab_41
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age;
            Console.Write("What is your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age: " + age);
            if(age <= 21)
            {
                Console.WriteLine("Youth is a wonderful thing. Enjoy.");
            }
            Console.WriteLine("Age is a state of mind.");

        }
    }
}
