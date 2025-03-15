using System;

public class Entry
{
    public string _Date;
    public string _Mood;
    public string _Prompt;
    public string _Response;



    public Entry(string date, string mood, string prompt, string response)
    {
        _Date = date;
        _Mood = mood;
        _Prompt = prompt;
        _Response = response;

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_Date}");
        Console.WriteLine($"Mood: {_Mood}");
        Console.WriteLine($"Prompt: {_Prompt}");
        Console.WriteLine($"Response: {_Response}");
        Console.WriteLine("-----------------------------------");
    }

    
    public string ToFileString()
    {
        return $"\"{_Date}\",\"{_Mood}\",\"{_Prompt}\",\"{_Response}\"";
    }

    
     public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        
        if (parts.Length >= 4)
        {
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            string mood = parts[3];
            
            return new Entry(date, prompt, response, mood);
        }
        else
        {
            Console.WriteLine("Error: Invalid entry format.");
            return null;
        }
    }
}