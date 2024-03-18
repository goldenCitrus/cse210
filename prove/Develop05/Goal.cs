public abstract class Goal
{

    public bool _isComplete;
    public string _name;

    public abstract void CreateGoal();

    public abstract void UpdateGoal();
}