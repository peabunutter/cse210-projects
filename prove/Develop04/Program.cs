// for my extra credit I made two methods at the bottom of activity. Using these two methods allow me to be able to say StartEnd() and Current()
//instead of DateTime start = DateTime.Now, DateTime end = start.AddSeconds(x), and DateTime current = DateTime.Now

class Program
{
    static void Main(string[] args)
    {
        Console.Write(">");
        Console.ReadLine();
        int choice;
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                breathing.Run();
            }
            else if (choice == 2)
            {
                reflect.Run();
            }
            else if (choice == 3)
            {
                listing.Run();
            }
        } while (choice != 4);
    }
}