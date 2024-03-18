public abstract class Goal
{

    public bool _isComplete;
    public string _name;

    public abstract void CreateGoal(GoalsHandler goalHandler);

    public abstract void UpdateGoal();
}