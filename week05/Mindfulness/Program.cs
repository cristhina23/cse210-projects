using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");

        
        DisplayMenu();
        string userChoice = Console.ReadLine();
        Console.WriteLine("\n");

        while (userChoice != "4")
        {
            DisplayMenu();
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
            case "1":
                BreathingActivity activity1 = new BreathingActivity();
                activity1.Run();
                break;
            case "2":
                ReflectingActivity activity2 = new ReflectingActivity();
                activity2.Run(); 
                break;
            case "3":                        
                ListingActivity activity3 = new ListingActivity();                
                activity3.Run();
                break;            
            case "4":
                Console.WriteLine("Goodbye!");                
                break;
            default:                
                Console.WriteLine("Invalid choice. Please try again.");                
                break;
            }
        }

        

        
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Selec a choice from the menu: ");
    }
}