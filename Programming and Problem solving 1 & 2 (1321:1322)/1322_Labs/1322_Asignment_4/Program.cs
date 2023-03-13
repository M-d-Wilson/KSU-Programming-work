using System;

namespace _Asignment_4
{
    class MainClass
    {
        public static string ChangeBase(int basenumb, int numb)
        {
            char supernumber;
            string newnNumb = "";
            int temp = numb / basenumb;

            if (numb >= basenumb)
                newnNumb = ChangeBase(basenumb, temp);

            numb %= basenumb;

            if (basenumb >= 0 && basenumb < 10)
            {
                //I can't get the code to output the first two numbers in the output if it is base 2

                newnNumb += numb;
            }
            else if (basenumb >= 10 && basenumb <= 36)
            {
                if (numb > 9)
                {
                    supernumber = (char)(numb + 55);
                    newnNumb += supernumber;
                }
                else
                {
                    newnNumb += numb;
                }
            }
            return newnNumb;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a basen number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " in decimal is " + ChangeBase(baseNumber, number) + " in base " + baseNumber + ".");

        }
    }
}
