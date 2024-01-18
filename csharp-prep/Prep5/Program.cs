using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        int SquareNumber(int numberToBeSquared)
        {
            int solution = numberToBeSquared * numberToBeSquared;
            return solution;
        }
        void DisplayResult(string usersName, int squaredNumber)
        {
            Console.WriteLine($"{usersName}, the square of your number is {squaredNumber}");
        }
        DisplayWelcome();
        string enteredName = PromptUserName();
        int enteredNumber = PromptUserNumber();
        int stageSquaring = SquareNumber(enteredNumber);
        DisplayResult(enteredName, stageSquaring);

    }
}