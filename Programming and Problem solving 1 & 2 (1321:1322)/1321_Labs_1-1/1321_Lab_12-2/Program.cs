using System;

namespace _Lab_122
{
    class MainClass
    {
        static Boolean Compare(int[] A1,int[] A2)
        {
            for(int j = 0;j < A1.Length; j++)
            {
                if (A1[j] == A2[j])
                {
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int i;
            Console.Write("What size is your Array: ");
            i = Convert.ToInt32(Console.ReadLine());
            int[] Arr1 = new int[i];
            int[] Arr2 = new int[i];
            for (i = 0; i < Arr1.Length;i++)
            {
                Console.Write("First Array at " + i + ": ");
                Arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < Arr2.Length;i++)
            {
                Console.Write("Second Array at " + i + ": ");
                Arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array length:     " + Arr1.Length);
            Console.Write("First array:      ");
            for(i = 0;i < Arr1.Length; i++)
            {
                Console.Write(Arr1[i]);
                if (i < 4)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.Write("Second array:     ");
            for (i = 0; i < Arr2.Length; i++)
            {
                Console.Write(Arr2[i]);
                if (i < 4)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            if (Compare(Arr1, Arr2))
            {
                Console.Write("Judgment:	The arrays are identical");
            }
            else
            {
                Console.Write("Judgment:	The arrays are not identical");
            }
        }
    }
}
