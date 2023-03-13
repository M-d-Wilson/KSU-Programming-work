using System;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Lab 2

namespace _Milo_Lab1BArray
{
    class MainClass
    {
        static int LongestPositiveSeries(int[,] Arr)
        {
            int i, j;
            int posString = 0, Bigly = 0;
            for (i = 0; i < Arr.GetLength(1); i++)
            {

                for (j = 0; j < Arr.GetLength(0); j++)
                {
                    if (Arr[i, j] > 0)
                    {
                        posString ++;
                    }
                    else
                    {
                        if(posString > Bigly)
                        {
                            Bigly = posString;
                        }
                        posString = 0;
                    }
                }
            }
            return Bigly;
        }

        public static void Main(string[] args)
        {
            int i, j;
            int[,] data = new int[5, 5];
            for (i = 0; i < data.GetLength(1); i++)
            {
                for (j = 0; j < data.GetLength(0); j++)
                {
                    Console.Write("What is the row " + i + " and column " + j + ": ");
                    data[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The longest string of posotives is: " + LongestPositiveSeries(data));
            for (i = 0; i < data.GetLength(1); i++)
            {
                for (j = 0; j < data.GetLength(0); j++)
                {
                    Console.Write("|" + data[i, j]);
                }
                Console.WriteLine("|");
            }
        }
    }
}
