using System;

namespace _Lab_71
{
    class MainClass
    {
		public static void Main(string[] args)
		{
			int i, j, space = 8, dots = 0;

			for (i = 0; i <= 8; i++)
			{
				for (j = 0; j < space; j++)
				{
					Console.Write(" ");
				}
				for (j = 0; j < dots; j++)
				{
					Console.Write("*");
				}
				Console.Write("*");
				for (j = 0; j < dots; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
				space--;
				dots++;
			}
		}
    }
}
