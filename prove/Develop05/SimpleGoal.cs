public class SimpleGoal : Goal
{

    public SimpleGoal(string name)
    {
        _name = name;
    }

    public override void CreateGoal(GoalsHandler goalHandler)
    {
        Console.Write("What would you like to call this goal: ");
        _name = Console.ReadLine();
        _isComplete = false;
        goalHandler.Goals.Add(this);
    }

    public override void UpdateGoal()
    {
        throw new NotImplementedException();
    }

}