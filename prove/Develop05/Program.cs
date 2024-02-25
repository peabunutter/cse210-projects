using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        GoalManager manager = new GoalManager();
        do
        {
            manager.Start();
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                manager.CreateGoal();
            }
            else if (option == 2)
            {
                manager.ListGoalDetails();
            }
            else if (option == 3)
            {
                manager.SaveGoals();
            }
            else if (option == 4)
            {
                manager.LoadGoals();
            }
            else if (option == 5)
            {
                manager.RecordEvent();
            }
        } while (option != 6);
    }
}