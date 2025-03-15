using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for today?",
        "What challenge did I overcome today?",
        "What did I learn about myself today?",
        "Describe a moment when you felt peace today.",
        "Who made your day better and how?",
        "What is something new you tried today?",
        "What was something kind you did for someone?",
        "What scripture or quote inspired you today?",
        "How did you serve someone today?",
        "What made you smile today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void AddEntry(Entry entry)
{
 

    Entries.Add(entry);
    
    Console.WriteLine("Entry added!\n");

}

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (Entry entry in Entries)
            {
                entry.Display();
            }
        }
    }
    // I need to fix this.
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (Entry entry in Entries)
        {
            string line = entry.ToFileString();
            writer.WriteLine(line);

           
            Console.WriteLine($"Guardando entrada: {line}");
        }
    }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
       if (File.Exists(filename))
    {
        Entries.Clear(); 
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
           
            if (!string.IsNullOrWhiteSpace(line))
            {
                
                string[] parts = line.Split('|');

               
                if (parts.Length >= 4)
                {
                    Entry entry = Entry.FromFileString(line);
                    Entries.Add(entry);
                }
                else
                {
                    
                    Console.WriteLine($"Línea inválida en el archivo: {line}");
                }
            }
        }

        Console.WriteLine("Journal loaded successfully 👍.");
    }
    else
    {
        Console.WriteLine("File not found. 🤷‍♀️");
    }
    }
}