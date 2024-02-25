using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    public List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu:");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.Name());
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        DisplayPlayerInfo();
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPrize = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(goalName, goalDesc, goalPrize));
        }
        if (choice == 2)
        {
            _goals.Add(new EternalGoal(goalName, goalDesc, goalPrize));
        }
        if (choice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.WriteLine($"What is the bonus for accomplishing it {goalTarget} times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            _goals.AddRange(new List<Goal>{new ChecklistGoal(goalName, goalDesc, goalPrize, goalTarget, goalBonus)});
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal item in _goals)
        {
            Console.WriteLine(item.Name());
        }
        Console.WriteLine("Which goal did you accomplish? ");
        int goalRecord = int.Parse(Console.ReadLine());
        Goal goal = _goals[goalRecord - 1];
        if (goal is SimpleGoal)
        {
            _score += goal.Points();
            goal.RecordEvent();
        }
        else if (goal is EternalGoal)
        {
            _score += goal.Points();
        }
        else if (goal is ChecklistGoal)
        {
            _score += goal.Points();
            goal.RecordEvent();
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("_goals.txt"))
        {
            foreach (Goal outputGoal in _goals)
            {
                outputFile.WriteLine(outputGoal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        var lines = System.IO.File.ReadAllLines("_goals.txt");

        foreach (string line in lines)
        {
            var goalParts = line.Split(":");
            string goalType = goalParts[0];
            var goalBits = goalParts[1].Split("|");
            if (goalType == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(goalBits[0], goalBits[1], int.Parse(goalBits[2]));
                _goals.Add(sg);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(goalBits[0], goalBits[1], int.Parse(goalBits[2]));
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal cg = new ChecklistGoal(goalBits[0], goalBits[1], int.Parse(goalBits[2]), int.Parse(goalBits[3]), int.Parse(goalBits[4]));
            }
            
        }
    }
}