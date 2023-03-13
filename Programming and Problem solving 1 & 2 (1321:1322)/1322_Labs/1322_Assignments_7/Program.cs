using System;
using System.Threading.Tasks;
using System.Diagnostics;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Asignment 7

namespace _Assignments_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbList = new int[10000];
            int[] secNumbList = new int[numbList.Length];
            numbList.CopyTo(secNumbList, 0);

            int temp;

            for (int i = 0; i < numbList.Length; i++)
            {
                numbList[i] = r.Next(0, 100);
            }
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Starting linear bubble sort, please wait...");
            Console.WriteLine();
            sw.Start();
            for (int p = 0; p <= numbList.Length; p++)
            {
                for (int i = 0; i <= numbList.Length - 2; i++)
                {
                    if (numbList[i] > numbList[i + 1])
                    {
                        temp = numbList[i + 1];
                        numbList[i + 1] = numbList[i];
                        numbList[i] = temp;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("Finished linear bubble sort.");
            Console.WriteLine();
            long timeOne = sw.ElapsedMilliseconds;

            Console.WriteLine("Starting parallel bubble sort, please wait...");
            Console.WriteLine();
            sw.Start();
            Parallel.For(0, secNumbList.Length, index =>
            {
                for (int i = 0; i <= secNumbList.Length - 2; i++)
                {
                    if (secNumbList[i] > secNumbList[i + 1])
                    {
                        temp = secNumbList[i + 1];
                        secNumbList[i + 1] = secNumbList[i];
                        secNumbList[i] = temp;
                    }
                }
            });
            sw.Stop();
            Console.WriteLine("Finished parallel bubble sort.");
            Console.WriteLine();
            long timeTwo = sw.ElapsedMilliseconds;

            Console.WriteLine("Time for linear bubble sort:       " + timeOne + " milliseconds");
            Console.WriteLine();
            Console.WriteLine("Time for parallel bubble sort:       " + timeTwo + " milliseconds");
            Console.WriteLine();
        }
        
    }
}
