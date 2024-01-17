using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int number = rng.Next(1, 11);
        int guessedNum;
        
        Console.WriteLine("Welcome to the random number guesser! Please guess a number between 1 and 10!");
        do
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guessedNum = int.Parse(guess);
            if (guessedNum != number)
            {
                Console.WriteLine("Wrong! Guess again!");
            }
        } while (guessedNum != number);

        Console.WriteLine("Congratulations! You guessed the correct number! You win!");
    }
}