using System;
class Program
{
    static void Main (string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess = 0;

        while (userGuess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            string userGuessStrg = Console.ReadLine();
            userGuess = int.Parse(userGuessStrg);

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

        }

        Console.WriteLine("You guessed it!");

    }
}
