using System;

public class Entry
{
    public string _Date;
    public string _Prompt;
    public string _Response;

    public Entry(string date, string prompt, string response)
    {
        _Date = date;
        _Prompt = prompt;
        _Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_Date}");
        Console.WriteLine($"Prompt: {_Prompt}");
        Console.WriteLine($"Response: {_Response}");
        Console.WriteLine("-----------------------------------");
    }

    
    public string ToFileString()
    {
        return $"{_Date}|{_Prompt}|{_Response}";
    }

    
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}