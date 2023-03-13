using System;

namespace _Lab_52
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int dayOfWeek, daysTill, dayOf;
            Console.WriteLine("0 for Sunday, 1 for Monday, 2 for Tuesday, 3 for Wednesday \n4 for Thursday, 5 for Friday, 6 for Saturday");
            Console.Write("What day is it: ");
            dayOfWeek = Convert.ToInt32(Console.ReadLine());
            Console.Write("The meetingis in how many days:");
            daysTill = Convert.ToInt32(Console.ReadLine());
            dayOf = (dayOfWeek + daysTill) % 7;
            Console.Write("The meeting is on ");
            switch (dayOf)
            {
                case 1:
                    Console.Write("Monday");
                    break;
                case 2:
                    Console.Write("Tuesday");
                    break;
                case 3:
                    Console.Write("Wednesday");
                    break;
                case 4:
                    Console.Write("Thursday");
                    break;
                case 5:
                    Console.Write("Friday");
                    break;
                case 6:
                    Console.Write("Saturday");
                    break;
                case 0:
                    Console.Write("Sunday");
                    break;
            }
        }
    }
}
