using System;
using System.Globalization;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // GoalsHandler goalsHandler = new GoalsHandler();
        // goalsHandler.PrintRoster();

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
                GoalsHandler goalsHandler = new GoalsHandler();
                if (File.Exists(goalsHandler.fileName))
                {
                    goalsHandler.PrintGoals(goalsHandler.Goals);
                    Console.WriteLine("Which Goal would you like to update?");
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
                        GoalsHandler goalsHandler = new GoalsHandler();
                        // SimpleGoal simpleGoal = new SimpleGoal();
                        goalsHandler.Goals.Add(new SimpleGoal("plewase"));
                        // simpleGoal.CreateGoal(goalsHandler);
                        // Console.WriteLine(simpleGoal._name + " " + simpleGoal._isComplete);
                        // Console.WriteLine(goalsHandler.Goals[0]);
                        string jsonString = JsonSerializer.Serialize(goalsHandler.Goals);
                        File.WriteAllText(goalsHandler.fileName, jsonString);
                        // goalsHandler.SaveToJson();
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
        }
    }
}