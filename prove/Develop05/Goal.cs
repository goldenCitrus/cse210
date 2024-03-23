using System.Dynamic;

public abstract class Goal
{
    public bool _isComplete {get; set;}
    public string _name {get; set;}
    public string _goalType {get; set;}
    public int _maxValue {get; set;}
    public int _currentValue {get; set;}
    public int _timesCompletd {get; set;}

    public abstract void CreateGoal(GoalsHandler goalsHandler);

    public abstract void UpdateGoal(GoalsHandler goalsHandler, int listIndex);
}