public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string rep = $"{_shortName}|{_description}|{_points}|{_isComplete}";
        return rep;
    }
    public override string GetDetailsString()
    {
        if (_isComplete == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }
}