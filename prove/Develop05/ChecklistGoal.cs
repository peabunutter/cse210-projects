public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private string _type;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _type = "ChecklistGoal";
    }
    public override int Points()
    {

        if (_amountCompleted == _target)
        {
            return _bonus + _points;
        }
        else
        {
            return _points;
        }
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        string rep = $"{_type}:{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
        return rep;
    }
}