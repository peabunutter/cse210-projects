public class OutdoorGathering : Event
{
    private string _weather;
    List<string> _weatherTypes = new List<string> {"Stormy", "Sunny", "Snowy", "Rainy", "Chilly", "Windy", "Foggy"};

    public OutdoorGathering(string title, string description, double date, double time, string address) : base(title, description, date, time, address)
    {
        _type = "Outdoor Gathering";
    }
    Random random = new Random();
    private string Weather()
    {
        int wTypeNum = random.Next(_weatherTypes.Count());
        _weather = _weatherTypes[wTypeNum];
        return _weather;
    }

    public override string Full()
    {
        return $"{Standard()} The weather forcast for this {_type} is {_weather}";
    }
}