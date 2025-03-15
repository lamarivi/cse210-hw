using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    journal.NewEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.SaveToFile("test.txt");
                    break;
                case "4":
                    journal.LoadFromFile("test.txt");
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

}