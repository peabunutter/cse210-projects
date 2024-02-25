public class EternalGoal : Goal
{
    private string _type;

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
        string rep = $"{_type}:{_shortName}|{_description}|{_points}";
        return rep;
    }
}