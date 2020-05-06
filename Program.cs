using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser(); 

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guessNumber = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guessNumber != correctNumber)
                {
                    string userGuess = Console.ReadLine();
                    //input validation 
                    if (!int.TryParse(userGuess, out guessNumber))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a valid number.");
                        continue;
                    }
                    //cast input to int and pass into guess 
                    guessNumber = Int32.Parse(userGuess);

                    if (guessNumber != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, guess again.");
                    }
                }
                //output success message
                PrintColorMessage(ConsoleColor.Green, "You got it!");


                //ask to play again
                Console.WriteLine("Play Again?[Y/N]");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }
                else if (playAgain == "N")
                {
                    Console.WriteLine("Thanks for playing! Have a great day!");
                    return;
                }
            }
        }

        static void GetAppInfo() 
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ben Stoica";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName}, Version: {appVersion}, By: {appAuthor} ");
            //resets text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string player = Console.ReadLine();
            Console.WriteLine($"Hello {player}, let's play a game.");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
