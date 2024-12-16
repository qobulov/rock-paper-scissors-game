using System;

namespace rock_paper_scissors_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                
                while(player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.Write("Choose rock, paper, or scissors: ");
                    player = Console.ReadLine()!;
                    player = player.ToLower();
                }

                computer = random.Next(1, 4).ToString();

                switch(computer)
                {
                    case "1":
                        computer = "rock";
                        break;
                    case "2":
                        computer = "paper";
                        break;
                    case "3":
                        computer = "scissors";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch(player)
                {
                    case "rock":
                        if(computer == "paper")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if(computer == "scissors")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("Tie!");
                        }
                        break;
                    case "paper":
                        if(computer == "scissors")
                        {
                            Console.WriteLine("You lose!");
                        }                        
                        else if(computer == "rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("Tie!");
                        }
                        break;
                    case "scissors":
                        if(computer == "rock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if(computer == "paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("Tie!");
                        }
                        break;
                }
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine()!;
                if (answer == "")
                {
                    Console.WriteLine("No input provided. Exiting the game.");
                    // ...
                }
                else
                {
                    answer = answer.ToUpper();
                    // ...
                }

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }                

            }
        }
    }
}