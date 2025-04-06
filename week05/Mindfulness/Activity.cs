abstract class Activity
{
    protected string Name;
    protected string Description;
     protected int Duration;
    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} ");
        Console.Write("Enter duration (sec): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Animate(3);
        PerformActivity();
        EndActivity();
    }

protected abstract void PerformActivity();
    protected void EndActivity()
    {
    Console.WriteLine("You have completed the activity :)");
    Console.WriteLine($"You spent {Duration} seconds");
    Animate(3);
    }

    protected void Animate(int seconds)
    {
        for (int i = 0; i<seconds; i++)
        {
            Thread.Sleep(1000);
        }
    }
}