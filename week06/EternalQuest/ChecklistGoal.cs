public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    private bool _isComplete = false;

public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points)
{
    _target = target;
    _bonus = bonus;
}
public override void RecordEvent()
{
    if (_isComplete) return;

    _amountCompleted++;

    if (_amountCompleted >= _target)
    {
        AddSetPointToCurrentPoint(); 
        _currentPoint += _bonus;     
        _isComplete = true;
    }
    else
    {
        AddSetPointToCurrentPoint();
    }
}

public override bool IsComplete()
{
    return _isComplete;
}

public override string GetStringRepresentation()
{
    return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}|{_isComplete}";
}
public override void SetIsCompleteToTrue()
{
    _isComplete = true;
}

public void AddSaveAmountCompleted(int amount)
{
    _amountCompleted = amount;
}

public override string GetGoalName()
{
    return _name;
}
}