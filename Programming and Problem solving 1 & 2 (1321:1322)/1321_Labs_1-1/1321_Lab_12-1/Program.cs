using System;

namespace _Lab_121
{
    class MainClass
    {
        static char letterGrade(int X)
        {
            if (X >= 90 && X <= 100)
            {
                return 'A';
            }
            else if (X >= 80 && X <= 89)
            {
                return 'B';
            }
            else if (X >= 70 && X <= 79)
            {
                return 'C';
            }
            else if (X >= 60 && X <= 69)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public static void Main(string[] args)
        {
            int UserInput, i;
            Console.Write("What size is your class: ");
            i = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[i];
            for (i = 0;i < Arr.Length;i++)
            {
                Console.Write("Enter student: " + i + " grade: ");
                UserInput = Convert.ToInt32(Console.ReadLine());
                Arr[i] = UserInput;
            }

            for (i = 0;i < Arr.Length; i++)
            {
                Console.WriteLine("Student " + i + " score is a " + Arr[i] + " and grade is " + letterGrade(Arr[i]));
            }


        }
    }
}
