using System;

namespace _Lab_33
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Q, D, N, P, Money;
            Console.Write("Enter number of quarters: ");
            Q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of dimes: ");
            D = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of nickels: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of pennies: ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered " + Q + "of quarters");
            Console.WriteLine("You entered " + D + "of dimes");
            Console.WriteLine("You entered " + N + "of nickels");
            Console.WriteLine("You entered " + P + "of pennies");
            Money = (25 * Q) + (10 * D) + (5 * N) + P;
            Console.Write("Your total is " + ((Money - (Money % 100)) / 100) + " Dollars and " + (Money % 100) + "Cents.");
        }
    }
}
