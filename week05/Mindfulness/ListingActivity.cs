public class ListingActivity : Activity
{
  List<string> _prompts = new List<string>();
  public ListingActivity() : base("Listing Activity", "This activity will help you on good things in your life by having you list as many things as you can in certain areas.")
  {
     _prompts = new List<string>
        {
          "When you have felt the Holy Ghost this month?",
          "List people who have been a blessing in your life.",
          "List things that make you feel peaceful and calm.",
          "List spiritual experiences that have strengthened your faith.",
          "List things you are grateful for today.",
          "List times when you served someone this week.",
          "List ways you have seen God's hand in your life.",
          "List things that bring you joy.",
          "List talents or gifts that God has given you.",
          "List things you have learned from trials or hard times."
        };
          
  }

  public void GetRandomPrompt()
  {
    Random random = new Random();
    int index = random.Next(_prompts.Count);
    
    Console.WriteLine(_prompts[index]);
  } 

  public void Run()
  {
    DisplayStartingMessage();
    
    Console.Write("\nHow long, in seconds, would you like for your session? ");
    int duration = int.Parse(Console.ReadLine());
    DateTime endTime = DateTime.Now.AddSeconds(duration);
    

    
    Console.Clear();
    Console.WriteLine("Get ready...");
    DisplaySpinner(5);
    Console.WriteLine("List as many responses as you can to the following prompt:");
    GetRandomPrompt();
    Console.WriteLine("\nYou may begin in: ");
    DisplayCountdown(5);

    List<string> responses = new List<string>();

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      responses.Add(Console.ReadLine());
    }
    Console.WriteLine($"You listed {responses.Count} items.\n");
    DisplayEndingMessage("Well done!");
  }
}