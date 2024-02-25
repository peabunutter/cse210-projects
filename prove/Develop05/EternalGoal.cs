public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        RecordEvent();
        return false;
    }
    public override string GetStringRepresentation()
    {
        string rep = $"{_shortName}|{_description}|{_points}";
        return rep;
    }
}