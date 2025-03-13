using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("-----------------------------------");
    }

    // Optional: convert to file line
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // Optional: create entry from file line
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}