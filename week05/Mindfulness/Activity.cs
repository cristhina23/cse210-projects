using System.ComponentModel.DataAnnotations;

public class Activity {
  private string _name;
  private string _description;
  private int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
    
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name}.\n");
    Console.WriteLine($"{_description}\n");
  }

  public void DisplayEndingMessage(string message)
  {
    Console.WriteLine($"{message}");
  }

  public void DisplaySpinner(int duration)
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);
    List<string> spinner = new List<string> {"|", "/", "-", "\\","|", "/", "-", "\\"};
    int i = 0;

    while (DateTime.Now < endTime)
    {
      string s = spinner[i];
      Console.Write(s);
      Thread.Sleep(500);
      Console.Write("\b \b"); 
      i ++;

      if (i >= spinner.Count)
      {
        i = 0; 
      }
    }
  }

  public void DisplayCountdown(int duration)
  {
    for (int i = duration; i > 0; i--)
    {
      Console.Write(i);
      
      Thread.Sleep(1000);
      Console.Write("\b \b");
      
    }
  }
}