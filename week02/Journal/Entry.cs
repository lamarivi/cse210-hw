using System;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _answer;

public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
        {
        "What was the most challenging moment today, and how did I handle it?",
        "Who did I interact with today that left an impact on me?",
        "What was something unexpected that happened today?",
        "f I could relive one moment from today, what would it be and why?",
        "How did I step out of my comfort zone today?",
        "What is one goal I worked toward today?",
        "What is one small thing I can do tomorrow to improve myself?",
        "What’s a personal challenge I’m facing, and how am I handling it?",
        "What made me feel grateful today?",
        "How did I practice kindness today?",
        "Did I have any meaningful conversations today? What did I take from them?",
        "If I could write a letter to my future self, what would it say?",
        "What is a value or belief that is important to me?"
        };

        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

public void GetResponse()
    {
        Console.Write("> ");
        _answer = Console.ReadLine();
    }
}
