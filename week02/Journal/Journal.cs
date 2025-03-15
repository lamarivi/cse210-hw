using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void NewEntry()
    {
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.GetResponse();
        _entries.Add(userEntry);

         Console.Write("Do you want to save this entry? (yes/no): ");
        string choice = Console.ReadLine();
        if (choice == "yes")
        {
            SaveToFile("test.txt");
        }
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._answer}");
            Console.WriteLine();
        }
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._answer}");
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file = "test.txt")
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._answer}");
            }
        }
        Console.WriteLine($"Journal saved successfully!");
    }

    public void LoadFromFile(string file = "test.txt")
    {
        if (!File.Exists(file))
    {
        Console.WriteLine("File not found!");
        return;
    }

    _entries.Clear();

    using (StreamReader reader = new StreamReader(file))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split('-');
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _answer = parts[2]
                };
                _entries.Add(entry);
            }
        }
    }
    Console.WriteLine($"Journal loaded successfully");
    }
}