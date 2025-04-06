class Listing : Activity 
{
    private List<string> _promptslisting;
    public Listing() : base("Listing Exercise", "This activity will help you reflect on a deeper level about your life")
    {
        _promptslisting = new List<string>
        {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
        };
    }

    protected override void PerformActivity()
    {
        var rand = new Random();
        Console.WriteLine(_promptslisting[rand.Next(_promptslisting.Count)]);
        Animate(3);

    DateTime endTime = DateTime.Now.AddSeconds(Duration);
    List<string> items = new List<string>();

    while (DateTime.Now < endTime)
    {
        Console.Write("Enter an item: ");
        string item = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(item))
        {
            items.Add(item);
        }
    }
    }
}