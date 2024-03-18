
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class GoalsHandler
{

    public List<Goal> Goals;

    public GoalsHandler()
    {
        Goals = new List<Goal>();
        if (File.Exists(fileName))
        {
            string jsonFromFile = File.ReadAllText(fileName);

            List<Goal> Goals = JsonSerializer.Deserialize<List<Goal>>(jsonFromFile);
        }
    }
    
    public string fileName = "goals.json";

    public void PrintGoals(List<Goal> goalss)
    {
        string completion;
        int num = 1;
        foreach (Goal goal in goalss)
        {
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($"{num}. {checklistGoal._name} - ");
                num++;
                for (int i = 0; i <= checklistGoal._maxValue; i++)
                {
                    if (checklistGoal._currentValue >= i)
                    {
                    Console.Write("☒ ");
                    } else {Console.Write("☐");} 
                }
                Console.Write("\n");
            }
            else if (goal is SimpleGoal simpleGoal)
            {
                if (simpleGoal._isComplete == true)
                {
                    completion = "☒";
                } else {completion = "☐";}
                Console.WriteLine($"{simpleGoal._name} - {completion}");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                Console.WriteLine($"{eternalGoal._name} - Completed {eternalGoal._timesCompletd} times");
            }
        }
    }

    public void SaveToJson()
    {
        string jsonString = JsonSerializer.Serialize(Goals);
        File.WriteAllText(fileName, jsonString);
    }
}