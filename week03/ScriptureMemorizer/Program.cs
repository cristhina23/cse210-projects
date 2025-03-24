using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromCSV("scriptures.csv");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found!");
            return;
        }

        Random rand = new Random();
        int randomIndex = rand.Next(scriptures.Count);
        Scripture scripture = scriptures[randomIndex];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Great job!");
                break;
            }
        }
    }

    static List<Scripture> LoadScripturesFromCSV(string filename)
{
    List<Scripture> scriptures = new List<Scripture>();

   
    if (File.Exists(filename))
    {
        
        string[] lines = File.ReadAllLines(filename);

        
        foreach (string line in lines)
        {
           
            string[] parts = line.Split(',');

            if (parts.Length >= 2)
            {
                string referenceText = parts[0].Trim();   
                string scriptureText = parts[1].Trim();   

                
                string[] refParts = referenceText.Split(' ');

                string book = refParts[0];               
                string chapterAndVerses = refParts[1];   

                
                string[] chapterSplit = chapterAndVerses.Split(':');
                int chapter = int.Parse(chapterSplit[0]); 

                string versePart = chapterSplit[1];       

                Reference reference;

               
                if (versePart.Contains('-'))
                {
                    string[] verses = versePart.Split('-');
                    int startVerse = int.Parse(verses[0]);
                    int endVerse = int.Parse(verses[1]);

                    
                    reference = new Reference(book, chapter, startVerse, endVerse);
                }
                else
                {
                    int verse = int.Parse(versePart);

                    
                    reference = new Reference(book, chapter, verse);
                }

                
                Scripture scripture = new Scripture(reference, scriptureText);
                scriptures.Add(scripture);
            }
        }
    }
    else
    {
        Console.WriteLine("File not found!");
    }

    return scriptures;
}

}

// I showed creativity and exceeded the assignment requirements by adding functionality 
// that allows the program to load multiple scriptures from an external CSV file. 
// Each time the program runs, it selects a random scripture from the list to display and memorize.
// This makes the experience more dynamic and helpful for people who want to practice memorizing 
// different scriptures, not just one. Additionally, I ensured the program only hides words 
// that have not yet been hidden, making it more challenging and realistic.
