using System;

class Program
{
    static void ClearConsole()
    {
        Console.Clear();
    }

    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 7, 45);
        string scriptureText = "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.";
        Scripture scripture = new Scripture(reference, scriptureText);


        while (true)
        {
            ClearConsole();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit:");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
                break;
            scripture.HideRandomWords(2); 
        }

        ClearConsole();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Program ended.");
    }
}