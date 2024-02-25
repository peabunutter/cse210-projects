using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("How to eat spaghetti", "You can finally learn how to eat spaghetti :D", 10.24, 10.30, "888 Spaghets Rd", "Mario Jump-Man Mario", 250);
        Reception reception = new Reception("Wedding Reception", "Wedding reception for Azerty and Qwerty", 5.19, 4.00, "North Keyboard Ave");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Birthday Party", "Birthday Party for Jimbo", 4.20, 4.30, "South Black Hole Ln");
        int choice = 0;
        do
        {
        Console.WriteLine("What gathering do you want informaiton on?");
        Console.WriteLine("1. Lecture\n2. Reception\n3. Outdoor Gathering");
        choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Choose the information you want:");
            Console.WriteLine("1. Shortened version\n2. Standard Version\n3. Long Version");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 1)
            {
                Console.WriteLine(lecture.Short());
            }
            else if (choice1 == 2)
            {
                Console.WriteLine(lecture.Standard());
            }
            else
            {
                Console.WriteLine(lecture.Full());
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Choose the information you want:");
            Console.WriteLine("1. Shortened version\n2. Standard Version\n3. Long Version");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 1)
            {
                Console.WriteLine(reception.Short());
            }
            else if (choice1 == 2)
            {
                Console.WriteLine(reception.Standard());
            }
            else
            {
                Console.WriteLine(reception.Full());
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Choose the information you want:");
            Console.WriteLine("1. Shortened version\n2. Standard Version\n3. Long Version");
            int choice1 = int.Parse(Console.ReadLine());
            if (choice1 == 1)
            {
                Console.WriteLine(outdoorGathering.Short());
            }
            else if (choice1 == 2)
            {
                Console.WriteLine(outdoorGathering.Standard());
            }
            else
            {
                Console.WriteLine(outdoorGathering.Full());
            }
        }
        else
        {
            break;
        }
        } while (choice != 4);
    }
}