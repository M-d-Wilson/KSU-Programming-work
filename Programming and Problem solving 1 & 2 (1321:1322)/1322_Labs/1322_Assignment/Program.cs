using System;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Asignment 1

namespace _Assignment
{
    class MainClass
    {
        class Test
        {
            private string[, ] Names = new string[10, 2];
            private double[, ] Scores = new double[10, 5];

            public Test()
            {
                int i, j;
                for(i = 0;i < Names.GetLength(0);i++)
                {
                    Console.Write("What is student " + (i+1) + " first name: ");
                    Names[i, 0] = Console.ReadLine();
                    Console.Write("What is student " + (i+1) + " last name: ");
                    Names[i, 1] = Console.ReadLine();
                }
                for(i = 0;i < Scores.GetLength(0);i++)
                {
                    for(j = 0;j < Scores.GetLength(1); j++)
                    {
                        Console.Write("Student " + (i+1) + " grade for test " + (j+1) + ": ");
                        Scores[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }

            public void SetGrade(int student, int test, double grade)
            {
                test--;
                Scores[student, test] = grade;
            }

            public double GetGrade(int student, int test)
            {
                test--;
                return Scores[student, test];
            }

            public double GetAverage(int Student)
            {
                double Average = 0;
                int j;
                for (j = 0; j < Scores.GetLength(1); j++)
                {
                    Average += Scores[Student, j];
                }
                Average /= 5;
                return Average;
            }

            public char GetLetterGrade(double Average)
            {
                if (Average >= 90)
                {
                    return 'A';
                }else if (Average >= 80)
                {
                    return 'B';
                }else if (Average >= 70)
                {
                    return 'C';
                }else if (Average >= 60)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }
            }

            public string GetFirst(int Student)
            {
                return Names[Student, 0];

            }

            public string GetLast(int Student)
            {
                return Names[Student, 1];

            }

            public void Tostring()
            {
                int i;
                Console.WriteLine("First Name - Last name - Test 1 - Test 2 " +
                    "- Test 3 - Test 4 - Test 5 - Average - Letter Grade:");
                for(i = 0;i < Scores.GetLength(0); i++)
                {
                    Console.WriteLine(GetFirst(i) + "    " + GetLast(i) + "  "
                        + GetGrade(i, 1) + "  " + GetGrade(i, 2) + "  " +
                        GetGrade(i, 3) + "  " + GetGrade(i, 4) + "  " +
                        GetGrade(i, 5) + "  " + GetAverage(i) + "  " +
                        GetLetterGrade(GetAverage(i)));
                }
            }

        }
        public static void Main(string[] args)
        {
            Test C1 = new Test();
            C1.Tostring();
        }
    }
}
