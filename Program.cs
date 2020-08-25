using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // string secretNumber = "42";
            int secretNumber = new Random().Next(1, 5);
            int numberAttempts = 0;

            Console.WriteLine("\n### GUESS THE NUMBER GAME ###");

            while (numberAttempts < 4) {
                Console.Write("\nGuess the secret number? >> ");
                int numberGuess = Int32.Parse(Console.ReadLine());

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats! You guessed the secret number!");
                    break;
                }
                else
                {
                    numberAttempts++;
                    // Console.WriteLine("Incorrect. Try again!");

                    if (numberGuess > secretNumber)
                    {
                        Console.WriteLine("Too high, Try again!");
                    }
                    else if (numberGuess < secretNumber)
                    {
                        Console.WriteLine("Too low. Try again!");
                    }

                    Console.WriteLine($"{numberAttempts} of {4 - numberAttempts} guesses left.");
                }

            }

        }
    }
}
