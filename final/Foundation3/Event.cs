public abstract class Event
{
    protected string _title;
    protected string _description;
    protected double _date;
    protected double _time;
    protected string _address;
    protected string _type;

    public Event(string title, string description, double date, double time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Short()
    {
        return $"{_title} on {_date}. This will be a {_type}.";
    }
    public string Standard()
    {
        return$"{_title} - {_description} \nAt {_time} on {_date} over at {_address}.";
    }
    public abstract string Full();
}