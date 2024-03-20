using System;
using System.Globalization;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        GoalsHandler goalsHandler = new GoalsHandler();
        // goalsHandler.PrintRoster();

        string fileName = "goals.json";

        List<string> menuOptions = new List<string>() {"View Or Edit Goals", "Create New Goal", "Quit", "1", "2", "3"};
        string userInput = "null";
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string titleCaseInput = textInfo.ToTitleCase(userInput);

        while (!menuOptions.Contains(titleCaseInput))
        {
            Console.WriteLine("What would you like to do?");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"{i+1}. {menuOptions[i]}");
            }
            userInput = Console.ReadLine();
            titleCaseInput = textInfo.ToTitleCase(userInput);

            if (titleCaseInput == "1" || titleCaseInput == "View Or Edit Goals")
            {
                // GoalsHandler goalsHandler = new GoalsHandler();
                if (File.Exists(fileName))
                {
                    goalsHandler.printGoals();
                    Console.ReadKey();
                    Console.Clear();
                    titleCaseInput = "null";
                    // Console.WriteLine("Which Goal would you like to update?");
                }
                else
                {
                    Console.WriteLine("You do not have any goals.\nPress any button to return to the main menu");
                    titleCaseInput = "null";
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if (titleCaseInput == "2" || titleCaseInput == "Create New Goal")
            {
                Console.Clear();
                bool beepBop = true;
                while (beepBop == true)
                {
                    Console.WriteLine("What type of goal would you like to create?\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal");
                    string chosenGoal = Console.ReadLine();
                    if (chosenGoal == "1" || chosenGoal.ToLower() == "simple goal")
                    {
                        // GoalsHandler goalsHandler = new GoalsHandler();
                        SimpleGoal simpleGoal = new SimpleGoal("test");
                        // simpleGoal.CreateGoal();
                        goalsHandler.goals.Add(simpleGoal);
                        // Console.WriteLine(goalsHandler.goals[0]);
                        beepBop = false;
                        titleCaseInput = "null";
                        Console.Clear();
                        Console.WriteLine($"{simpleGoal._name} has successfully been created!");
                    }
                    else if (chosenGoal == "2" || chosenGoal.ToLower() == "checklist goal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                    }
                    else if (chosenGoal == "3" || chosenGoal.ToLower() == "eternal goal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                    }
                    else {Console.Clear();Console.WriteLine($"Invalid input '{chosenGoal}'");}
                }
            }
            else if (titleCaseInput == "3" || titleCaseInput == "Quit")
            {
                break;
            }
            else if (titleCaseInput == "4")
            {
                string jsonString = JsonSerializer.Serialize(goalsHandler);
                Console.WriteLine(jsonString);
                File.WriteAllText(fileName, jsonString);
            }
            else
            {
                Console.WriteLine($"Invalid input '{titleCaseInput}'");
            }
        }
    }
}