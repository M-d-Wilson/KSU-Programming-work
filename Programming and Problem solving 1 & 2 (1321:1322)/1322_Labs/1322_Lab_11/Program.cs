using System;

namespace _Lab_11
{
    public class TimeException : Exception
    {
        public string message;

        public TimeException(string message) : base(message)
        {
            this.message = message;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput = "";
            while (userInput != "n")
            {
                Console.WriteLine();
                Console.Write("Enter a time in 24-hour format: ");
                userInput = Console.ReadLine();
                int hours, mins;
                try
                {
                    string[] values = userInput.Split(':');
                    hours = int.Parse(values[0]);
                    mins = int.Parse(values[1]);
                }
                catch(FormatException e)
                {
                    Console.Write(e.StackTrace);
                    continue;
                }

                try
                {
                    if (mins > 59 || mins < 0)
                    {
                        throw new TimeoutException("The number of minutes was not valid, try again.");
                    }
                }
                catch (TimeoutException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try
                {
                    if (hours > 24 || hours < 0)
                    {
                        throw new TimeoutException("The number of hours was not valid, try again.");
                    }
                    else if(hours == 0)
                    {
                        Console.WriteLine("Same time in 12-hour format: 12:" + mins + " PM");

                    }
                    else if (hours > 12)
                    {
                        hours -= 12;
                        if (mins < 10)
                        {
                            Console.WriteLine("Same time in 12-hour format: " + hours + ":0" + mins + " PM");
                        }
                        else
                        {
                            Console.WriteLine("Same time in 12-hour format: " + hours + ":" + mins + " PM");
                        }
                    }
                    else
                    {
                        if (mins < 10)
                        {
                            Console.WriteLine("Same time in 12-hour format: " + hours + ":0" + mins + " AM");
                        }
                        else
                        {
                            Console.WriteLine("Same time in 12-hour format: " + hours + ":" + mins + " AM");
                        }
                    }
                }
                    catch (TimeoutException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

            Console.Write("Continue? ");
                    userInput = Console.ReadLine();

            }
        }
    }
}
