public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _currentPoint = 0;
    protected string _checkBox = "[ ]";

    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();

    public abstract string GetGoalName();

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual void SetIsCompleteToTrue()
    {
        
    }

    public int GetCurrentPoint()
    {
        return _currentPoint;
    }



    public void AddSetPointToCurrentPoint()
    {
        _currentPoint += _points;
    }
 public void SetCheckMark()
    {
        string newCheckBox = _checkBox.Replace(_checkBox, "[✓]");
        _checkBox = newCheckBox;
    }

    public string GetCheckMark()
    {
        return _checkBox;
    }
}
