using System;

namespace GuessNumberApp
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
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                while (guess != correctNumber)
                {
                    Console.WriteLine("Guess a number between 1 and 10");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "Please enter an actual number!");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Red, "Wrong Number! Please guess it again!");

                    }

                }

                PrintColor(ConsoleColor.Yellow, "You are correct!");
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine();

                if (answer == "N")
                {
                    break;
                }

                else
                {
                    continue;
                }

            }
           
        }

        static void GetAppInfo()
        {
            string appName = "Number Gusser App";
            string appVersion = "1.0.0";
            string appAuthor = "Haruka Kotani";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's plya a game...", name);
        }

        static void PrintColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
} 