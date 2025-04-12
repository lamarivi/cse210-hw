public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) {}

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckMark()} {_name} - {_description}";
    }

    public override string GetGoalName()
    {
        return _name;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
}