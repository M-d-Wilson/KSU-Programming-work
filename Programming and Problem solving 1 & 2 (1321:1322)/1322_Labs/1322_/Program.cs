using System;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Lab 1

namespace _
{
class MainClass
{
    static int[] fillData()
    {
        Random rnd = new Random();
        int[] data = new int[20];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = Convert.ToInt32(rnd.Next(-100, 101));
        }
        return data;
    }

    static int findLargest(int[] Arr)
    {
        int biggest = Arr[0];
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i] > biggest)
            {
                biggest = Arr[i];
            }
        }
        return biggest;
    }
    public static void Main(string[] args)
    {
        int frequency, duration;
        Console.Write("What is the frequency: ");
        frequency = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the duration: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.Beep(frequency, duration);

        int[] nums = { 1, 4, 13, 43, -25, 17, 22, -37, 29 };
        int[] data = new int[20];
        data = fillData();
        int Big1 = findLargest(nums);
        int Big2 = findLargest(data);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("|" + nums[i]);

        }
        Console.WriteLine("|");
        Console.WriteLine("Largest number in the first array: " + Big1);
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write("|" + data[i]);
        }
        Console.WriteLine("|");
        Console.WriteLine("Largest number in the second array: " + Big2);
        Console.WriteLine("The largest combined: " + (Big1 + Big2));
    }
}
}
