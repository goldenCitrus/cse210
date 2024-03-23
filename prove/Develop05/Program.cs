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
        GoalsHandler goalsHandler;
        // goalsHandler.PrintRoster();
        

        string fileName = "goals.json";
        
        if (File.Exists(fileName))
        {
            string jsonFromFile = File.ReadAllText(fileName);
            goalsHandler = JsonSerializer.Deserialize<GoalsHandler>(jsonFromFile);
        }
        else
        {
            // FileStream fs = File.Create("myFile.txt");
            // fs.Close();
            goalsHandler = new GoalsHandler();
        }

        List<string> menuOptions = new List<string>() {"View Or Edit Goals", "Create New Goal", "Quit", "1", "2", "3"};
        string userInput = "null";
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string titleCaseInput = textInfo.ToTitleCase(userInput);

        while (!menuOptions.Contains(titleCaseInput))
        {
            goalsHandler.Setup();
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
                    bool loop = true;
                    bool invalidInput = false;
                    string goalChoice = "";
                    while (loop)
                    {
                        goalsHandler.Setup();
                        Console.Clear();
                        if (invalidInput)
                        {
                            Console.WriteLine($"Invalid input '{goalChoice}'. Please enter a number or 'back':");
                        }
                        goalsHandler.PrintGoals();
                        Console.WriteLine("Press the number corresponding to the goal you would like to edit, or type 'back' to return to the previous menu");
                        goalChoice = Console.ReadLine();
                        int goalChoiceNum;
                        bool canConvert = int.TryParse(goalChoice, out goalChoiceNum);
                        goalChoiceNum = goalChoiceNum-1;
                        if (canConvert)
                        {
                            if (goalChoiceNum >= 0 && goalChoiceNum < goalsHandler.goals.Count)
                            {
                                loop = false;
                                goalsHandler.goals[goalChoiceNum].UpdateGoal(goalsHandler, goalChoiceNum);
                            }
                            else
                            {
                                invalidInput = true;
                            }
                        }
                        else if (goalChoice.ToLower() == "back")
                        {
                            loop = false;
                        }
                        else
                        {
                            invalidInput = true;
                        }

                    }

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
                    goalsHandler.Setup();
                    Console.WriteLine("What type of goal would you like to create?\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal");
                    string chosenGoal = Console.ReadLine();
                    if (chosenGoal == "1" || chosenGoal.ToLower() == "simple goal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.CreateGoal(goalsHandler);
                        // goalsHandler.goals.Add(simpleGoal);
                        beepBop = false;
                        titleCaseInput = "null";
                        Console.Clear();
                        Console.WriteLine($"{simpleGoal._name} has successfully been created!");
                        // Console.WriteLine(goalsHandler.goals[0]);
                        goalsHandler.SaveGoals(goalsHandler);
                        // string jsonString = JsonSerializer.Serialize(goalsHandler);
                        // File.WriteAllText("goals.json", jsonString);
                    }
                    else if (chosenGoal == "2" || chosenGoal.ToLower() == "checklist goal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.CreateGoal(goalsHandler);
                        beepBop = false;
                        titleCaseInput = "null";
                        Console.Clear();
                        Console.WriteLine($"{checklistGoal._name} has successfully been created!");
                        goalsHandler.SaveGoals(goalsHandler);
                    }
                    else if (chosenGoal == "3" || chosenGoal.ToLower() == "eternal goal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.CreateGoal(goalsHandler);
                        beepBop = false;
                        titleCaseInput = "null";
                        Console.Clear();
                        Console.WriteLine($"{eternalGoal._name} has successfully been created!");
                        goalsHandler.SaveGoals(goalsHandler);
                    }
                    else {Console.Clear();Console.WriteLine($"Invalid input '{chosenGoal}'");}
                }
            }
            else if (titleCaseInput == "3" || titleCaseInput == "Quit")
            {
                break;
            }
            // else if (titleCaseInput == "4")
            // {
                // string jsonString = JsonSerializer.Serialize(goalsHandler);
                // Console.WriteLine(jsonString);
                // File.WriteAllText(fileName, jsonString);
            // }
            else
            {
                Console.WriteLine($"Invalid input '{titleCaseInput}'");
            }
        }
    }
}