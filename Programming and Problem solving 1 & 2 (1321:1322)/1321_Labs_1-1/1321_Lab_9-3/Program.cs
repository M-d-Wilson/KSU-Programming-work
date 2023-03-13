using System;

namespace _Lab_93
{
    class MainClass
    {
        static int NewNumber()
		{
			Random rnd = new Random();
			int num;
			num = (int) rnd.Next(1, 20);
			return num;

		}

        static int Geuss()
		{
			int UserInput = 1;
			do
			{
				if (UserInput > 20 || UserInput < 1)
				{
					Console.WriteLine("Input invalid. Try again.");
				}
				Console.Write("geuss a number between 1 and 20: ");

				UserInput = Convert.ToInt32(Console.ReadLine());
			} while(UserInput > 20 || UserInput < 1);
			return UserInput;
		}

        static Boolean Result(int UserInput, int RandNum)
		{
            if(UserInput == RandNum)
			{
				Console.WriteLine("Good job you geussed right!");
				return false;
			}else if(UserInput > RandNum)
            {
				Console.WriteLine("Wrong geuss. it was higher than the number;");
				return true;
			}else if(UserInput < RandNum)
			{
				Console.WriteLine("Wrong geuss. it was lower than the number;");
				return true;
			}
			else
			{
				return true;
			}
		}

        public static void Main(string[] args)
        {
            int MagicNum, UserInput;
			Boolean End = false;
			MagicNum = NewNumber();
			do
			{
				UserInput = Geuss();
				End = Result(UserInput, MagicNum);
			} while (End);

        }
    }
}
