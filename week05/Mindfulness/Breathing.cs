class Breathing : Activity
{
    public Breathing() : base("Breathing Exercise", "This activity will help you relax with breathing exercises"){}
    protected override void PerformActivity()
    {
        int rounds = Duration / 4;
        for (int i = 0; i < rounds; i++)
        {
            Console.WriteLine("Breathe in...");
            Animate(2);
            Console.WriteLine("Breathe out...");
            Animate(2);
        }
    }
}