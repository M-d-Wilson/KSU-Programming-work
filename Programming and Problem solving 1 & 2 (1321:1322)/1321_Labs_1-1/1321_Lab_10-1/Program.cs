using System;

namespace _Lab_101
{
    class Rectangle
	{
		private double hight, width;

		public Rectangle()
		{
			hight = 1.0;
			width = 1.0;
		}

		public Rectangle(double H, double W)
		{
			hight = H;
			width = W;
		}

		public double getArea()
		{
			double A;
			A = getHeight() * getWidth();
			return A;
		}

		public double getPerimeter()
		{
			double P;
			P = (2 * (getHeight())) + (2 * (getWidth()));
			return P;
		}

		public double getHeight()
		{
			return hight;
		}

		public double getWidth()
		{
			return width;
		}

	}

	class MainClass
    {
        public static void Main(string[] args)
        {
            double UserInput1,Userinput2;
			Rectangle rec1 = new Rectangle();
			Console.Write("What is your rectangle's hught:  ");
			UserInput1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("What is your rectangle's width:  ");
			Userinput2 = Convert.ToInt32(Console.ReadLine());
			Rectangle rec2 = new Rectangle(UserInput1, Userinput2);
			Console.WriteLine("Firs object:\n" +
				"   Hight:     " + rec1.getHeight() + " units\n" +
				"   Width:     " + rec1.getWidth() + " units\n" +
				"   Area:      " + rec1.getArea() + " unit\n" +
				"   Perimeter: " + rec1.getPerimeter() + " units");
			Console.WriteLine();
			Console.WriteLine("Second object:\n" +
				"   Hight:     " + rec2.getHeight() + " units\n" +
				"   Width:     " + rec2.getWidth() + " units\n" +
				"   Area:      " + rec2.getArea() + " unit\n" +
				"   Perimeter: " + rec2.getPerimeter() + " units");
		}
    }
}
