using System;

//Milo WIlson
//Lab Final

namespace _FINAL_Q2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput;
            int[] playerPos = new int[2];
            char[,] playFeild = new char[5,5];
            char[,] bomobFeild = new char[5,5];
            int numbOfBombs = 0;
            int temp = 0;
            int round = 0;
            int points = 0;
            Random random = new Random();
            bool run = true;


            for (int r = 0; r < playFeild.GetLength(0); r++)
            {
                for (int c = 0; c < playFeild.GetLength(1); c++)
                {
                    playFeild[c, r] = '_';
                }
            }

            for (int r = 0; r < bomobFeild.GetLength(0); r++)
            {
                for (int c = 0; c < bomobFeild.GetLength(1); c++)
                {
                    bomobFeild[c, r] = 'S';
                }
            }

            while (numbOfBombs < 5)
            {
                temp = random.Next(1, 25);
                if(bomobFeild[(int)(temp % 5), (int)(temp / 5)] == 'S')
                {
                    bomobFeild[(int)(temp % 5), (int)(temp / 5)] = 'B';
                    numbOfBombs++;
                }
            }

            while (run)
            {
                Console.WriteLine("Our field for round "+ round + ": ");
                for (int r = 0; r < playFeild.GetLength(0); r++)
                {
                    for (int c = 0; c < playFeild.GetLength(1); c++)
                    {
                        Console.Write(playFeild[c, r]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("Please enter a position to sweep for mines:");
                userInput = Console.ReadLine();
                Console.WriteLine();
                playerPos[0] = Convert.ToInt32(userInput[0].ToString());
                playerPos[1] = Convert.ToInt32(userInput[3].ToString());

                if ((playerPos[0] <= 4 && playerPos[0] >= 0) && (playerPos[1] <= 4 && playerPos[1] >= 0))
                {
                    if (bomobFeild[playerPos[0], playerPos[1]] == 'S')
                    {
                        playFeild[playerPos[0], playerPos[1]] = 'S';
                        round++;
                        points++;
                    }
                    else if (bomobFeild[playerPos[0], playerPos[1]] == 'B')
                    {
                        Console.WriteLine("Sorry! You stepped on a mine in round " + round + ".You had " + points + " points.");
                        Console.WriteLine();
                        run = false;
                    }
                }
                else
                {
                    Console.Write("That is an invalid position, please enter a position between 0 and 4 for the row and column.");
                    Console.WriteLine();
                }
            }            
            Console.WriteLine("The actual field: ");

            for (int r = 0; r < bomobFeild.GetLength(0); r++)
            {
                for (int c = 0; c < bomobFeild.GetLength(1); c++)
                {
                    Console.Write(bomobFeild[c, r]);
                }
                Console.WriteLine();
            }
        }
    }
}
