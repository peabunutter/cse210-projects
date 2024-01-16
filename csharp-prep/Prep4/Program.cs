using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int max = 0;

        Console.Write("Enter a number, type 0 when finished: ");
        string number = Console.ReadLine();
        int append = int.Parse(number);
        numbers.Add(append);

        do
        {
            Console.Write("Enter a number: ");
            number = Console.ReadLine();
            append = int.Parse(number);
            numbers.Add(append);
        } while (append != 0);
        numbers.Remove(0);

        foreach (int numeral in numbers)
        {
            sum += numeral;
        }
        Console.WriteLine($"Your sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        foreach (int numeral in numbers)
        {
            if (numeral > max)
            {
                max = numeral;
            }
        }
        Console.WriteLine($"The highest number is {max}");

    }
}