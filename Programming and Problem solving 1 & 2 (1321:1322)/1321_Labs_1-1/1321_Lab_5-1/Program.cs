using System;

namespace _Lab_51
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int grade1, grade2, grade3, grade4, lowestGrade, highestGrade, avrage;
            Console.Write("Grade 1: ");
            grade1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade 2: ");
            grade2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade 3: ");
            grade3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade 4: ");
            grade4 = Convert.ToInt32(Console.ReadLine());
            highestGrade = grade1;
            if (grade2 >= grade1 && grade2 >= grade3 && grade2 >= grade4)
            {
                highestGrade = grade2;
            }
            if (grade3 >= grade1 && grade3 >= grade2 && grade3 >= grade4)
            {
                highestGrade = grade3;
            }
            if (grade4 >= grade1 && grade4 >= grade2 && grade4 >= grade3)
            {
                highestGrade = grade4;
            }
            lowestGrade = grade1;
            if (grade2 <= grade1 && grade2 <= grade3 && grade2 <= grade4)
            {
                lowestGrade = grade2;
            }
            if (grade3 <= grade1 && grade3 <= grade2 && grade3 <= grade4)
            {
                lowestGrade = grade3;
            }
            if (grade4 <= grade1 && grade4 <= grade2 && grade4 <= grade3)
            {
                lowestGrade = grade4;
            }
            avrage = ((grade1 + grade2 + grade3 + grade4) / 4);
            Console.WriteLine("You entered:     " + grade1 + ", " + grade2 + ", " + grade3 + ", " + grade4);
            Console.WriteLine("Highest grade:   " + highestGrade);
            Console.WriteLine("Lowest grade:    " + lowestGrade);
            Console.WriteLine("Average grade:   " + avrage);
        }
    }
}
