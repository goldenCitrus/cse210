
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;
public class GoalsHandler
{

    public List<Goal> goals {get; set;}
    public List<SimpleGoal> simpleGoals {get; set;}
    public List<ChecklistGoal> checklistGoals {get; set;}
    public List<EternalGoal> eternalGoals {get; set;}


    public GoalsHandler()
    {
        goals = new List<Goal>();
        simpleGoals = new List<SimpleGoal>();
        checklistGoals = new List<ChecklistGoal>();
        eternalGoals = new List<EternalGoal>();
    }

    public void Setup()
    {
        if (goals.Count <= 0)
        {
            foreach (SimpleGoal simpleGoal in simpleGoals)
            {
                goals.Add(simpleGoal);
            }
            foreach (ChecklistGoal checklistGoal in checklistGoals)
            {
                goals.Add(checklistGoal);
            }
            foreach (EternalGoal eternalGoal in eternalGoals)
            {
                goals.Add(eternalGoal);
            }
        }
    }

    public int points {get; set;}

    public void PrintGoals()
    {
        Console. WriteLine($"Points: {points}\nAll Goals:");
        string completion;
        int num = 0;
        foreach (Goal goal in goals)
        {
            num++;
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($"{num}. {checklistGoal._name} - ");
                for (int i = 0; i <= checklistGoal._maxValue; i++)
                {
                    if (i >= 1)
                    {
                        if (checklistGoal._currentValue >= i)
                        {
                        Console.Write("☒ ");
                        } else {Console.Write("☐ ");} 
                    }
                }
                Console.Write("\n");
            }
            else if (goal is SimpleGoal simpleGoal)
            {
                if (simpleGoal._isComplete == true)
                {
                    completion = "☒";
                } else {completion = "☐";}
                Console.WriteLine($"{num}. {simpleGoal._name} - {completion}");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                Console.WriteLine($"{num}. {eternalGoal._name} - Completed {eternalGoal._timesCompletd} times");
            }
        }
    }

    public void SaveGoals(GoalsHandler goalsHandler)
    {
        simpleGoals.Clear();
        checklistGoals.Clear();
        eternalGoals.Clear();
        foreach (Goal goal in goals)
        {
            if (goal._goalType == "Simple")
            {
                simpleGoals.Add((SimpleGoal)goal);
            }
            else if (goal._goalType == "Checklist")
            {
                checklistGoals.Add((ChecklistGoal)goal);
            }
            else if (goal._goalType == "Eternal")
            {
                eternalGoals.Add((EternalGoal)goal);
            }
        }
        goals.Clear();
        string jsonString = JsonSerializer.Serialize(goalsHandler);
        File.WriteAllText("goals.json", jsonString);
    }

}