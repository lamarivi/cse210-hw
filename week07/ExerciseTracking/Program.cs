using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 15, 4), 30, 4.8),
            new Cycling(new DateTime(2025, 15, 4), 60, 48.0),
            new Swimming(new DateTime(2025, 15, 4), 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}