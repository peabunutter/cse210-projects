public class Address
{
    private string _street;
    private string _state;
    private string _country;

    public Address()
    {
        Console.Write("What is your address? ");
        _street = Console.ReadLine();
        Console.Write("\nWhat state/province do you live in? ");
        _state = Console.ReadLine();
        Console.Write("\nWhat country do you live in?");
        _country = Console.ReadLine();
    }
    public bool USA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string Location()
    {
        return $"{_street}\n{_state}, {_country}";
    }
}