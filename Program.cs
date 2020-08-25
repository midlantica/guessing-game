using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n### GUESS THE NUMBER GAME ###");

            int secretNumber = new Random().Next(1, 10);
            int numberAllowedGuesses = 3;
            int numberAttempts = 0;
            bool difficultySet = false;
            Console.WriteLine($"Number of guesses: {numberAllowedGuesses}");

            while (!difficultySet)
            {
                Console.Write($"Select difficulty: \n1) Easy \n2) Medium \n3) Hard \n4) Cheater \n>> ");
                string difficulty = Console.ReadLine();

                if (difficulty == "1")
                {
                    numberAllowedGuesses = 8; // Easy
                    difficultySet = true;
                }
                else if (difficulty == "2")
                {
                    numberAllowedGuesses = 6; // Medium
                    difficultySet = true;
                }
                else if (difficulty == "3")
                {
                    numberAllowedGuesses = 4; // Hard
                    difficultySet = true;
                }
                else if (difficulty == "4")
                {
                    numberAllowedGuesses = 2000; // Cheater
                    difficultySet = true;
                }
            }

            while (numberAttempts < numberAllowedGuesses)
            {

                Console.Write("\nGuess the secret number? >> ");
                int numberGuess = Int32.Parse(Console.ReadLine());

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine($"Congrats! You guessed the secret number!");
                    break;
                }
                else
                {
                    numberAttempts++;

                    if (numberGuess > secretNumber)
                    {
                        Console.WriteLine($"Too high, Try again!");
                    }
                    else if (numberGuess < secretNumber)
                    {
                        Console.WriteLine($"Too low. Try again!");
                    }

                    Console.WriteLine($"{numberAllowedGuesses - numberAttempts} guesses left.");
                }
            }
        }
    }
}
