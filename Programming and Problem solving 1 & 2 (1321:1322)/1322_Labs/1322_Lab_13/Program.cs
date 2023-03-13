using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

//Milo Wilson
//1322 Lab Section 10
//Shweta Khandal
//Lab 13

namespace _Lab_13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberOfThe = 0;
            bool run = true;
            string userFileToCopy = "";
            string text;
            while (run)
            {
                // I added this bacause I assume the file path will be diferent on the
                // computer that is used to check this.
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
            text = File.ReadAllText(userFileToCopy).ToLower();
            string[] textArr = text.Split(' ');

            var t1 = Task.Run(() => {
                for (int i = 0; i < textArr.Length; i++)
                {
                    if (textArr[i] == "the")
                    {
                        numberOfThe++;
                        Console.WriteLine(textArr[i] + "  " + numberOfThe);
                    }
                    else if (textArr[i].Contains('\n'))
                    {
                        // this is here for the "the"'s that are at the end or begining of 
                        // a line because the document starts a new line rather than leting
                        // the text move down lines based on the window's size.
                        string[] lineWrap = textArr[i].Split('\n');

                        if (lineWrap[1] == "the")
                        {
                            numberOfThe++;
                            Console.WriteLine(textArr[i] + "  " + numberOfThe);
                            Console.WriteLine("===");
                        }
                        else if (textArr[i].Contains("the\r"))
                        {
                            numberOfThe++;
                            Console.WriteLine(textArr[i] + "  " + numberOfThe);
                            Console.WriteLine("===");
                        }
                    }
                    // theses else ifs are for specal cases like when the is the first word in a quote
                    // or in a compund words. I am missing 11 to have all intences of the word "the"
                    // but I'm not going to go through a whole novle looking for 11 "the"'s
                    else if (textArr[i].Contains('`'))
                    {
                        //for all of the the's Dodo says
                        if (textArr[i] == "`the")
                        {
                            numberOfThe++;
                            Console.WriteLine(textArr[i] + "  " + numberOfThe);
                            Console.WriteLine("===");
                        }
                    }
                    else if (textArr[i].Contains('\"'))
                    {
                        //for all of the the's that start quotes
                        if (textArr[i] == "\"the")
                        {
                            numberOfThe++;
                            Console.WriteLine(textArr[i] + "  " + numberOfThe);
                            Console.WriteLine("===");
                        }
                    }
                    else if (textArr[i].Contains('('))
                    {
                        //for all of the the's that start in perentheses
                        if (textArr[i] == "(the")
                        {
                            numberOfThe++;
                            Console.WriteLine(textArr[i] + "  " + numberOfThe);
                            Console.WriteLine("===");
                        }
                    }
                    else if (textArr[i].Contains("--"))
                    {
                        //for all of the the's that have two dashes ifront of them
                        if (textArr[i] == "--the" || textArr[i] == "the--\'")
                        {
                            numberOfThe++;
                            Console.WriteLine(textArr[i] + "  " + numberOfThe);
                            Console.WriteLine("===");
                        }
                    }
                    else if (textArr[i].Contains("-the-"))
                    {
                        //for compound words
                        numberOfThe++;
                        Console.WriteLine(textArr[i] + "  " + numberOfThe);
                        Console.WriteLine("===");
                    }

                }
            });
            Task.WaitAll(t1);
            Console.WriteLine("There are " + numberOfThe + " in Alice's Adventures in Wonderland");
        }
    }
}
