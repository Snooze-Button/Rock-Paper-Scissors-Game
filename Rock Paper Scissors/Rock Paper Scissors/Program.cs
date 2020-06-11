using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //MAKE GUI LESS CONFUSING //
            string playerInput;
            int randomInt;
            bool repeat = true;
            int scorePlayer = 0;
            int scoreCPU = 0;
            int Draws = 0;

            while (repeat == true)
            {

                Console.WriteLine("Welcome to Rock Paper Scissors \n");
                Console.WriteLine("It is easy to play, Enter Rock ,  Paper or Scissors \n");
                Console.WriteLine("When you have enter one of the 3 choices the computer will then randomly generate one of its own choice \n");

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Lets Begin , Enter rock, paper , scissors \n");
                    playerInput = Console.ReadLine();

                    //initialising new random class "rnd" //
                    Random rnd = new Random();
                    // randomint a integer variable stores random values between 1 and 4//
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1://Rock

                            if (playerInput == "rock")
                            {
                                Console.WriteLine("\n Computer choose Rock \n");
                                Draws++;
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("\n Computer choose Rock \n"); //Player Wins !!\n"); can also be added after \n for less Console.WriteLine //
                                scorePlayer++;
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("\n Computer choose Rock \n");
                                scoreCPU++;
                            }

                            break;
                        case 2://Paper

                            if (playerInput == "rock")
                            {
                                Console.WriteLine("\n Computer choose Paper \n");
                                scoreCPU++;
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("\n Computer choose Paper \n");
                                Draws++;
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("\n Computer choose Paper \n");
                                scorePlayer++;
                            }
                            break;
                        case 3://Scissors

                            if (playerInput == "rock")
                            {
                                Console.WriteLine("\n Computer choose Scissors \n");
                                scorePlayer++;
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("\n Computer choose Scissors \n");
                                scoreCPU++;
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("\n Computer choose Scissors \n");
                                Draws++;
                            }
                            break;
                        default:
                            break;


                    }
                    Console.WriteLine("Scores: Player:{0} CPU:{1} DRAWS:{2}\n\n" , scorePlayer , scoreCPU , Draws);
                }
                
                if (scorePlayer == 3)
                {
                    Console.WriteLine("CONGRATS!!! YOU HAVE BEATEN THE CPU!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU HAS WON!! BETTER LUCK NEXT TIME");
                }

                Console.WriteLine("Wanna Play again (Y/N)?");
                string loop = Console.ReadLine();
                if (loop == "Y")
                {
                    repeat = true;
                    Console.Clear();
                }
                else if (loop == "N")
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Please Enter Y for Yes and N for No");
                }

            }
        }
    }
}
