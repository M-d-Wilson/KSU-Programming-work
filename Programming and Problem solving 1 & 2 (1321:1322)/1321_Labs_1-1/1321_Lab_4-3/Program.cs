using System;

namespace _Lab_43
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int grade, serch;
            Console.WriteLine("What is your grade: ");
            grade = Convert.ToInt32(Console.ReadLine());
            serch = (grade / 10) % 10;
            Console.WriteLine("You entered " + grade);
            switch (serch)
            {
                case 0:
                    Console.WriteLine("That grade is a perfect score. Well done.");
                    break;
                case 9:
                    Console.WriteLine("That grade is well above average. Excellent work.");
                    break;
                case 8:
                    Console.WriteLine("That grade is above average. Nice job.");
                    break;
                case 7:
                    Console.WriteLine("That grade is average work.");
                    break;
                case 6:
                    Console.WriteLine("That grade is not good, you should seek help!");
                    break;
                default:
                    Console.WriteLine("That grade is not passing.");
                    break;
            }

        }
    }
}
