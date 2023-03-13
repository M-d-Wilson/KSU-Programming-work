using System;

namespace _Lab_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("There are " + countVowels(userInput, 0) + " vowels in \"" + userInput + "\"");
        }

        public static int countVowels(string s, int count)
        { 
            if (s.Length == 0)
            {
                return count;
            }
            else
            {
                if (s[0] == 'a' || s[0] == 'A' || s[0] == 'e' || s[0] == 'E' || s[0] == 'i' ||
                s[0]== 'I' || s[0] == 'o' || s[0] == 'O' || s[0] == 'u' || s[0] == 'U')
                {
                    count++;
                }

                return countVowels(s.Substring(1), count);
            }
        }
    }
}
