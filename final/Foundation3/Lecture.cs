public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, double date, double time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string Full()
    {
        return $"{Standard()} The speaker will be {_speaker}, and the room will only be able to hold {_capacity} people.";
    }
}