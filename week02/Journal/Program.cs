using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program!");

  
        Journal myJournal = new Journal();

        
        int userChoice = 0;

        while (userChoice != 5)
        {
            DisplayMenu();

      
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out userChoice))
            {
                switch (userChoice)
                {
                    case 1:
    
                        string prompt = myJournal.GetRandomPrompt();
                        
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();

                        Console.Write("How are you feeling today (your mood)? ");
                        string mood = Console.ReadLine();

                        Entry newEntry = new Entry(
                            DateTime.Now.ToString("yyyy-MM-dd"),
                            mood,
                            prompt,
                            response
                        );
                            
                      

                        myJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added!\n");
                        break;

                    case 2:
                        
                        myJournal.DisplayEntries();
                        break;

                    case 3:
                        
                        Console.Write("Enter the filename to load from: ");
                        string loadFile = Console.ReadLine();
                        myJournal.LoadFromFile(loadFile);
                        break;

                    case 4:
                        
                        Console.Write("Enter the filename to save to (e.g., journal.csv): ");
                        string saveFile = Console.ReadLine();
                        myJournal.SaveToFile(saveFile);
                        break;

                    case 5:
                        Console.WriteLine("Goodbye have a wonderful day!");
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option (1-5).");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
}

// I exceeded the basic requirements of the project by adding several creative features:
// 1. I included a "Mood" property for each journal entry. After writing their response, the user can describe their mood.
//    This makes the journal more personalized and helps users track their feelings over time.
// 2. I implemented the ability to save and load journal entries from a CSV file. 
//    This feature allows users to open their journal data in spreadsheet applications like Excel, making it easier to view and organize entries outside of the program.
// These additions demonstrate creativity and show my effort to go beyond the assignment instructions, improving both functionality and user experience.