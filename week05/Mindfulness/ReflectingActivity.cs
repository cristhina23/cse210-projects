public class ReflectingActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in others aspects of your life.")
  {

     _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you pushed through fear to do the right thing.",
            "Think of a time when you learned something important about yourself."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?",
            "What would you do differently if you had the chance?"
        };
  }

  
  public void GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    
    Console.WriteLine(_prompts[index]);
  } 

  public void GetRandomQuestion()
  {
    Random random = new Random();
    int index = random.Next(_questions.Count);
    Console.WriteLine(_questions[index]);
  }

  public void DisplayPrompt() 
  {
    GetRandomPrompt();
  }

  public void DisplayQuestion()
  {
    GetRandomQuestion();
  }

  public void Run()
  {
    DisplayStartingMessage();

     Console.Write("\nHow long, in seconds, would you like for your session? ");
    int duration = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Get ready...");
    DisplaySpinner(5);
   

    DateTime endTime = DateTime.Now.AddSeconds(duration);

     Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.Clear(); 


   while (DateTime.Now < endTime)
    {
       
        DisplayQuestion();
        DisplaySpinner(5);
        Thread.Sleep(5000); 
       
         
    }
    DisplaySpinner(5);
    DisplayEndingMessage("Well done!");
    DisplaySpinner(5);
    DisplayEndingMessage($"\nYou have completed another {duration} seconds of the Reflecting Activity.");
    DisplaySpinner(5);
  }

}