public class Customer
{
    private string _name;

    public Customer()
    {
        Console.Write("What is your name? ");
        _name = Console.ReadLine();
    }
    public string Name()
    {
        return _name;
    }
}