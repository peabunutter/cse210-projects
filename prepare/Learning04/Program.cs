using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Portrid", "math");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Portrid", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Title of a Book by Book Berson", "Portrid", "Books :)");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}