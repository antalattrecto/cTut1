using System;
using System.Collections.Generic;


namespace RockPaperScissors

{

    public class RandomStringInArraySample
    {
        static void Main(string[] args)
        {


        Start:

            try
            {

                int i = 1;
                int userScore = 0;
                int pcScore = 0;
                


                List<string> responses = new List<string>();
                responses.AddRange(new string[] { "ROCK", "PAPER", "SCISSORS" });
                Random random = new Random();

                Console.WriteLine("Hello! Enter your user name and hit Enter!");
                string userName = Console.ReadLine();

                Console.WriteLine("Hi, {0}. This is ROCK, PAPER, SCISSORS! You have five rounds to beat the computer. Good luck!", userName);

                while (i < 6)
                {

                    
                    Console.WriteLine("Round {0}: Type ROCK, PAPER, SCISSORS and hit Enter!", i);
                    string userInput = Console.ReadLine().ToUpper();
                    Console.WriteLine("User's choice was: {0}", userInput);
                    string pcInput = responses[random.Next(0, responses.Count)].ToUpper();
                    Console.WriteLine("PC's choice was: {0}", pcInput);



                    


                    if (userInput == "SCISSORS" && pcInput == "SCISSORS")
                    {

                        userScore++;
                        pcScore++;
                        
                        Console.WriteLine("Draw! User: {0}; PC: {1}", userScore, pcScore);

                    }

                    else if (userInput == "SCISSORS" && pcInput == "ROCK")
                    {
                        pcScore++;
                        
                        Console.WriteLine("PC won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "SCISSORS" && pcInput == "PAPER")
                    {
                        userScore++;
                        
                        Console.WriteLine("Good job! User won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "PAPER" && pcInput == "PAPER")
                    {
                        userScore++;
                        pcScore++;
                        
                        Console.WriteLine("Draw! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "PAPER" && pcInput == "SCISSORS")
                    {
                        pcScore++;
                        
                        Console.WriteLine("PC won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "PAPER" && pcInput == "ROCK")
                    {
                        userScore++;
                        
                        Console.WriteLine("Good job! User won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "ROCK" && pcInput == "PAPER")
                    {

                        pcScore++;
                        
                        Console.WriteLine("PC won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "ROCK" && pcInput == "SCISSORS")
                    {
                        userScore++;
                     
                        Console.WriteLine("Good job! User won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    else if (userInput == "ROCK" && pcInput == "ROCK")
                    {
                        userScore++;
                        pcScore++;
                        
                        Console.WriteLine("Draw! User: {0}; PC: {1}", userScore, pcScore);

                    }

                    else

                    {
                        pcScore++;
                        
                        Console.WriteLine("PC won! User: {0}; PC: {1}", userScore, pcScore);

                    }
                    i++;
                }


                string result1 = "User has won the game!";
                string result2 = "PC has won the game!";
                string result3;

                if (pcScore < userScore)
                {
                    result3 = result1;
                }

                else if (pcScore == userScore)
                {
                    result3 = "It's a draw!";
                }

                else
                {
                    result3 = result2;
                }

                Console.WriteLine("Hi {0}. Your final score is: {1}. The PC's final score is: {2}. {3}", userName, userScore, pcScore, result3);
                Console.WriteLine("Would you like to play another game (yes or no)?");
                string userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "yes")
                {
                    goto Start;
                }

                else
                {
                    Console.WriteLine("Thanks for playing {0}. See you soon!", userName);
                    System.Threading.Thread.Sleep(2500);
                }

            }

            catch (FormatException e)

            {
                Console.WriteLine("Invalid text input! Hit enter and try again ... An error occured: {0}", e);
                goto Start;
            }


        }
    }
}


