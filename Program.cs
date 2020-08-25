using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretNumber = "42";
            int numberAttempts = 0;

            while (numberAttempts < 4) {
                Console.WriteLine("Can you guess the secret number?");
                string numberGuess = Console.ReadLine();

                if (numberGuess == secretNumber)
                {
                    Console.WriteLine("Congrats! You guessed the secret number!");
                    break;
                }
                else
                {
                    numberAttempts++;
                    Console.WriteLine("Try again!");
                }
            }


        }
    }
}
