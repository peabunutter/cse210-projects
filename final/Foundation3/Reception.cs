public class Reception : Event
{
    private string _register;

    public Reception(string title, string description, double date, double time, string address) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _register = "CompanysEmailAddress.EmailUsHereAndNowhereElse.PleaseAnd.ThankYou@gmailOrSomething.com"; //typing this email is why everything was super late, sorry about that
    }

    public override string Full()
    {
        return $"{Standard()} RSVP @{_register}";
    }
}