public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    Random random = new Random();
    private string p1 = "\n-- Think of a time when you stook up for someone else. -- ";
    private string p2 = "\n-- Think of a time when you did something really difficult. -- ";
    private string p3 = "\n-- Think of a time when you helped someone in need. -- ";
    private string p4 = "\n-- Think of a time when you did something truly selfless -- ";
    private string q1 = "\n-- Why was this experience meaningful to you? -- ";
    private string q2 = "\n-- Have you ever done anything like this before? -- ";
    private string q3 = "\n-- How did you get started? -- ";
    private string q4 = "\n-- How did you feel when it was complete? -- ";
    private string q5 = "\n-- What made this time different than other times when you were not as successful? -- ";
    private string q6 = "\n-- What is your favorite thing about this experience? -- ";
    private string q7 = "\n-- What could you learn from this experience that applies to other situations? -- ";
    private string q8 = "\n-- What did you learn about yourself through this experience? -- ";
    private string q9 = "\n-- How can you keep this experience in mind in the future? -- ";
    
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> {p1, p2, p3, p4};
        _questions = new List<string> {q1, q2, q3, q4, q5, q6, q7, q8, q9};
    }
    public void Run()
    {
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        int spinDuration = _duration / 2;
        ShowSpinner(5);
        DisplayPrompt();
        ShowSpinner(spinDuration);
        DisplayQuestions();
        ShowSpinner(spinDuration);
        _duration = spinDuration * 2;
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        int randPrompt = random.Next(_prompts.Count);
        return _prompts[randPrompt];
    }
    private string GetRandomQuestion()
    {
        int randQuestion = random.Next(_questions.Count);
        return _questions[randQuestion];
    }
    private void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }
    private void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
    }
}