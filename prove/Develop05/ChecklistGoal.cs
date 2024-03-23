using System.Text.Json;

public class ChecklistGoal : Goal
{

    public override void CreateGoal(GoalsHandler goalsHandler)
    {
        Console.Write("What would you like to call this goal: ");
        _name = Console.ReadLine();
        _isComplete = false;
        _goalType = "Checklist";
        bool asking = true;
        while (asking == true)
        {
            Console.Write("How Many times would you like to be able to complete this goal: ");
            string desiredNum = Console.ReadLine();
            int num;
            if (int.TryParse(desiredNum, out num))
            {
                num = int.Parse(desiredNum);
                _maxValue = num;
                _currentValue = 0;
                goalsHandler.goals.Add(this);
                asking = false;
            }
            else
            {
                Console.WriteLine($"Invalid input '{desiredNum}' please enter a number");
            }
            
        }
    }

    public override void UpdateGoal(GoalsHandler goalsHandler, int listIndex)
    {
        Console.Clear();
        if (goalsHandler.goals[listIndex]._isComplete == false)
        {
            goalsHandler.goals[listIndex]._currentValue += 1;
            if (_currentValue < _maxValue)
            {
                goalsHandler.points += 50;
                goalsHandler.SaveGoals(goalsHandler);
                Console.WriteLine("Box Checked!");
            }
            else if (_currentValue == _maxValue)
            {
                goalsHandler.points += 500;
                goalsHandler.goals[listIndex]._isComplete = true;
                goalsHandler.SaveGoals(goalsHandler);
                Console.WriteLine("Box Checked! Congratulations on completing your goal!!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }    
    }

    public override string ToString()
    {
        return $"{this._name} is currently {this._isComplete}, with a type of {this._goalType}";
    }

}