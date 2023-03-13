using System;

namespace _Lab_23
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int length, hight;
            Console.WriteLine("Enter a hight: ");
			hight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter a width: ");
			length = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The area: " + (hight * length));
			Console.WriteLine("The perimiter: " + (2 * (hight + length)));
		}
	}
}
