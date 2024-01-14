using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string grade = "";
        Boolean pass = true;

        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (number >= 70)
        {
            pass = true;
        }
        else
        {
            pass = false;
        }

        Console.WriteLine($"Your grade is {grade}.");
        
        if (pass == true)
        {
            Console.WriteLine("You passed!! Congratulations!!");
        }
        else
        {
            Console.WriteLine("Oops. Looks like you failed. Embarrassing...");
        }
    }
}