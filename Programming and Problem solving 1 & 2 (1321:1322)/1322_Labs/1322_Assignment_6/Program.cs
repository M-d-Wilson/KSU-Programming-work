using System;
using System.IO;

namespace _Assignment_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInpt = "";
            string userFileToCopy = "";
            string userFileToWrite = "";
            bool run = true;

            while (run)
            {
                Console.WriteLine("Please enter a text file to coppy name and location:");
                Console.WriteLine();
                userFileToCopy = Console.ReadLine();
                Console.WriteLine();

                if (File.Exists(userFileToCopy))
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("This file does not exist!");
                    Console.WriteLine();
                }
            }
            run = true;

            while (run)
            {
                Console.WriteLine("Please enter a new file put text into name and location:");
                Console.WriteLine();
                userFileToWrite = Console.ReadLine();
                Console.WriteLine();

                if (File.Exists(userFileToWrite))
                {
                    Console.WriteLine("A file already exists with that name!");
                    Console.WriteLine();
                    Console.Write("Would you like to overwrite it or enter a different name? (0 or 1) ");
                    userInpt = Console.ReadLine();
                    Console.WriteLine();

                    if (userInpt == "0")
                    {
                        run = false;
                        Console.WriteLine("The file will be overwritten.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("This file does not exist!");
                    Console.WriteLine();
                }
            }

            WriteFile(userFileToWrite, CopyFile(userFileToCopy));

            Console.WriteLine("The file: \"" + userFileToCopy + "\" has been copied to \"" + userFileToWrite + "\"");
            Console.WriteLine();
        }

        public static string CopyFile(string fileToCopy)
        {               
            return File.ReadAllText(fileToCopy);
        }

        public static void WriteFile(string filetoWrite, string text)
        { 
                File.WriteAllText(filetoWrite, text);
        }
    }
}
