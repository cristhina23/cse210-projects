public class BreathingActivity : Activity
{
  public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {
    
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
    while (DateTime.Now < endTime)
    {
      Console.Write("\nBreathe in... ");
      DisplayCountdown(5);
      Console.Write("\nNow breathe out... ");
      DisplayCountdown(5);
      Console.WriteLine();
    }
    DisplaySpinner(5);
    DisplayEndingMessage("\nWell done!");
    DisplaySpinner(5);
    DisplayEndingMessage($"\nYou have completed another {duration} seconds of the Breathing Activity.");
    
    
  }

}