using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                new Breathing().StartActivity();
                break;
                case "2":
                new Reflection().StartActivity();
                break;
                case "3":
                new Listing().StartActivity();
                break;
                case "4":
                Console.WriteLine("Goodbye :)");
                return;
            }
        }
    }
}