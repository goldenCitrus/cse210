using System.Text.Json;

public class SimpleGoal : Goal
{

    public override void CreateGoal(GoalsHandler goalsHandler)
    {
        Console.Write("What would you like to call this goal: ");
        _name = Console.ReadLine();
        _isComplete = false;
        _goalType = "Simple";
        goalsHandler.goals.Add(this);
    }

    public override void UpdateGoal(GoalsHandler goalsHandler, int listIndex)
    {
        if (goalsHandler.goals[listIndex]._isComplete == false)
        {
            Console.Clear();
            Console.WriteLine("Goal Completed!!");
            goalsHandler.points += 100;
            goalsHandler.goals[listIndex]._isComplete = true;
            goalsHandler.SaveGoals(goalsHandler);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("This goal is already  completed.");
        }
    }

    public override string ToString()
    {
        return $"{this._name} is currently {this._isComplete}, with a type of {this._goalType}";
    }
}