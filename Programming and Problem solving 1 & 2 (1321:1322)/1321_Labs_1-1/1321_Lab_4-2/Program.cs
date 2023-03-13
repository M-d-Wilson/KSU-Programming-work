using System;

namespace _Lab_42
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hours, money;
            Console.Write("How long did you work: ");
            hours = Convert.ToInt32(Console.ReadLine());
            money = 10 * hours;
            if(hours > 40)
            {
                money = 400 + ((hours - 40) * 15);
            }
            Console.WriteLine("You entered " + hours + " hours.");
            Console.WriteLine("Gross earning is $" + money + ".");
        }
    }
}
