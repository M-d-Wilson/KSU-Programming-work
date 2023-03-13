using System;
using System.Collections;
using System.IO;

//Milo WIlson
//Lab Final

namespace _FINAL_Q1
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput = "";
            string fileToWrite = "";
            bool run = true;
            ArrayList userList = new ArrayList();

            while (userInput != "done")
            {
                Console.Write("Please enter some text to save: ");
                userInput = Console.ReadLine();
                Console.WriteLine();
                if(userInput != "done")
                    userList.Add(userInput);
            }

            while (run)
            {
                Console.Write("Please enter a location and name for the new file: ");
                fileToWrite = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    TextWriter tw = File.CreateText(fileToWrite);

                    for (int i = 0; i < userList.Count; i++)
                    {
                        tw.WriteLine((string)userList[i]);
                    }
                    tw.Close();
                    Console.WriteLine("The file was successfully created. Below are the contents of the file to verify that: ");
                    Console.WriteLine();
                    Console.WriteLine(File.ReadAllText(fileToWrite));
                    run = false;

                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.WriteLine("The new file was not able to be saved. Try checking the location and file name for errors (like having a space in the path).");
                }

            }
            
        }
    }
}
