public class EternalGoal : Goal
{
    
    public override void CreateGoal(GoalsHandler goalsHandler)
    {
        Console.Write("What would you like to call this goal: ");
        _name = Console.ReadLine();
        _isComplete = false;
        _goalType = "Eternal";
        goalsHandler.goals.Add(this);
    }

    public override void UpdateGoal(GoalsHandler goalsHandler, int listIndex)
    {
        Console.Clear();
        Console.WriteLine("Score Increased!");
        goalsHandler.points += 75;
        goalsHandler.goals[listIndex]._timesCompletd += 1;
        goalsHandler.SaveGoals(goalsHandler);
    }

        public override string ToString()
    {
        return $"{this._name} has been completed {this._timesCompletd} times, with a type of {this._goalType}";
    }
    
}