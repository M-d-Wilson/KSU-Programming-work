using System;

namespace _Lab_123
{
    class MainClass
    {
        static int arrayMax(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1;i < arr.Length;i++)
            {
                if (arr[i] > temp)
                {
                    temp = arr[i];
                }
            }
            return temp;
        }

        static int arrayMin(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length;i++)
            {
                if (arr[i] < temp)
                {
                    temp = arr[i];
                }
            }
            return temp;
        }

        static void arraySquared(int[] arr)
        {
            Console.Write("Square array:    ");
            for (int i = 0;i < arr.Length;i++)
            {
                Console.Write((arr[i] * arr[i]));
                if (i < 5)
                {
                    Console.Write(", ");
                }
            }
        }

        static void arrayReverse(int[] arr)
        {
            Console.Write("Reversed array:    ");
            for (int i = (arr.Length - 1); i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
        }

        public static void Main(string[] args)
        {
            int i;
            int[] Arr = new int[5];
            for (i = 0; i < Arr.Length; i++)
            {
                Console.Write("Array at " + i + ": ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Origenal array:    ");
            for (i = 0; i > Arr.Length; i++)
            {
                Console.Write(Arr[i]);
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Max Value:   " + arrayMax(Arr));
            Console.WriteLine("Min Value:   " + arrayMin(Arr));
            arraySquared(Arr);
            Console.WriteLine();
            arrayReverse(Arr);

        }
    }
}
