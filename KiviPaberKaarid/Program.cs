using System;

namespace KiviPaberKaarid
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string computerChoice;

            int userState = 0;
            int computerState = 0;

            while (userState < 3 && computerState < 3)
            {
                Console.WriteLine("Rock, paper, or scissors?");
                userInput = Console.ReadLine().ToLower();

                Random rnd = new Random();

                int randomNumber = rnd.Next(1, 4);

                if (randomNumber == 1)
                {
                    computerChoice = "rock";
                }
                else if (randomNumber == 2)
                {
                    computerChoice = "paper";
                }
                else
                {
                    computerChoice = "scissors";
                }

                if (userInput == computerChoice)
                {
                    Console.WriteLine($"It's a draw! The computer also chose {userInput}");
                }
                else if (userInput == "rock" && computerChoice == "scissors")
                {
                    userState++;
                    Console.WriteLine($"You got a point! The computer chose scissors. You now have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "rock" && computerChoice == "paper")
                {
                    computerState++;
                    Console.WriteLine($"You lost! The computer chose paper. You have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "paper" && computerChoice == "rock")
                {
                    userState++;
                    Console.WriteLine($"You got a point! The computer chose rock. You now have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "paper" && computerChoice == "scissors")
                {
                    computerState++;
                    Console.WriteLine($"You lost! The computer chose scissors. You have {userState} points and the compter has {computerState} points.");
                }
                else if (userInput == "scissors" && computerChoice == "paper")
                {
                    userState++;
                    Console.WriteLine($"You got a point! The computer chose paper. You now have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "scissors" && computerChoice == "rock")
                {
                    computerState++;
                    Console.WriteLine($"You lost! The computer chose rock. You have {userState} points and the computer has {computerState} points.");
                }
                else
                {
                    Console.WriteLine("Sorry, please try again!");
                }

            }
            if (userState == 3)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("The computer won.");
            }
        }
    }
}
