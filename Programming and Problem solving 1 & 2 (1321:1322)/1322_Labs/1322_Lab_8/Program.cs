using System;

namespace _Lab_8
{
    class MainClass
    {
        public static bool Palendrome(string X)
        {
            if (X.Length <= 2)
            {
                if (X[0] == X[X.Length - 1])
                {
                    return true;
                }
                return false;
            }
            else
            {
                string Cut = X.Substring(1, X.Length - 2);
                if (Palendrome(Cut))
                {
                    if(X[0] == X[X.Length - 1])
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            if (Palendrome(userInput))
            {
                Console.WriteLine(userInput + " is palindrome");
            }
            else
            {
                Console.WriteLine(userInput + " is not palindrome");
            }
        }
    }
}
