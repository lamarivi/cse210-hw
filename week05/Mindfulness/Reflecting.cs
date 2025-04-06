class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection() : base("Reflection", "This activity will help you reflect on your life")
    {
        _prompts = new List<string>
        {
        "Think about a time you overcame a fear",
        "Reflect on a time when you forgave someone",
        "Think of a time when you stayed calm under pressure",
        "Remember a moment when you felt very proud of yourself"
        };

        _questions = new List<string>
        {
        "Would you handle the same situation differently today?",
        "What part of this experience are you most proud of?",
        "Did anyone influence your actions during that time?",
        "What did you learn about yourself through this experience?"
        };
    }
    protected override void PerformActivity()
    {
        var rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Animate(3);

        int elapsed = 0;
        while (elapsed < Duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            Animate(5);
            elapsed += 5;
        }
    }
}