using System;

namespace _Lab_4
{
    public abstract class Geometric : ICloneable, IComparable
    {
        protected int SideLength;
        protected double Area;

        public override string ToString()
        {
            return this.GetType().Name + "'s: |Side Length: " + SideLength +" |Area: " + Math.Round(Area, 2);
        }

        public object Clone()
        {
            return (Geometric)this.MemberwiseClone();
        }

        public int CompareTo (object Oj)
        {
            int OJLength = ((Geometric)Oj).SideLength;
            double OJArea = ((Geometric)Oj).Area;

            if (OJLength == SideLength && OJArea == this.Area)
            {
                return 0;
            }else if(OJLength < SideLength && OJArea < this.Area)
            {
                return 1;
            }else
            {
                return -1;
            }
        }
    }

    public class Octegon : Geometric
    {
        public Octegon()
        {
            SideLength = 8;
            Area = (2 * (1 + Math.Sqrt(2)) * Math.Pow(SideLength, 2));
        }

        public Octegon(int x)
        {
            SideLength = x;
            Area = (2 * (1 + Math.Sqrt(2)) * Math.Pow(SideLength, 2));
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Octegon Octo1 = new Octegon();
            Geometric Octo2 = (Geometric)Octo1.Clone();
            Console.WriteLine("First " + Octo1);
            Console.WriteLine("Second " + Octo2);

            int Ret = Octo1.CompareTo(Octo2);
            if (Ret == 0)
            {
                Console.Write("The 2 geometric objects are the same.");
            }
            else if (Ret < 0)
            {
                Console.Write("The area and side length of the first is larger than the second.");
            }
            else if (Ret > 0)
            {
                Console.Write("The area and side lenght of the second area is larger than the forst.");
            }
        }
    }

    
}
