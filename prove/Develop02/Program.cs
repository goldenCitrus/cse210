using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] menuOptions = {"Create Entry", "Load Entry", "Exit", "1", "2", "3"};
        string menuSelection;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


        Console.WriteLine("Welcome to the Journal. What would you like to do today?");
        do
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }
            menuSelection = Console.ReadLine();
            menuSelection = textInfo.ToTitleCase(menuSelection);
            if (Array.IndexOf(menuOptions, menuSelection) < 0)
            {
                Console.WriteLine($"Invalid input '{menuSelection}'. Please enter one of the following:");
            }
        } while (Array.IndexOf(menuOptions, menuSelection) < 0);
        // Journal load = new();
        // string test = load.LoadFromFile();
        // Console.WriteLine(test);
        // QuestionGenerator question = new();
        // Console.WriteLine($"{question.GenerateQuestion()}");
    }
}