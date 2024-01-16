using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("What is the highest number?");
        string height = Console.ReadLine();
        int high = int.Parse(height);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, high);
        Console.WriteLine("What is your guess?");
        string guess2 = Console.ReadLine();
        int guess = int.Parse(guess2);
        do
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                string x = Console.ReadLine();
                guess = int.Parse(x);
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                string x = Console.ReadLine();
                guess = int.Parse(x);
            }
        } while (guess != number);
        Console.WriteLine("Correct!");
    }
}