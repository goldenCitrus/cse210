public class SimpleGoal : Goal
{

    // public SimpleGoal(string name)
    // {
    //     _name = name;
    // }

    public override void CreateGoal()
    {
        Console.Write("What would you like to call this goal: ");
        _name = Console.ReadLine();
        _isComplete = false;
        // goalHandler.goals.Add(this);
    }

    public override void UpdateGoal()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{this._name} is currently {this._isComplete}";
    }
}