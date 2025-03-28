using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("************Welcome!***********");
        Console.WriteLine("-------------------------------");
        
        Console.WriteLine();
        
        
        var videoBasics = new Video("C# Basics Tutorial", "CodeAcademy", 600);
        var videoReact = new Video("Learn React in 30 Minutes", "TechWithTim", 1800);
        var videoPython = new Video("Python for Beginners", "ProgrammingSimplified", 1500);

            
        videoBasics._comments.Add(new Comment("Alice", "Great explanation!"));
        videoBasics._comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        videoBasics._comments.Add(new Comment("Charlie", "Awesome tutorial."));

        videoReact._comments.Add(new Comment("Dave", "I love React!"));
        videoReact._comments.Add(new Comment("Eva", "Clear and concise."));
        videoReact._comments.Add(new Comment("Frank", "Could you do one on Redux?"));

        videoPython._comments.Add(new Comment("George", "Python is so cool."));
        videoPython._comments.Add(new Comment("Helen", "Amazing tutorial!"));
        videoPython._comments.Add(new Comment("Ivy", "Please make more of these."));

        videoBasics.DisplayVideoInfo();
        videoReact.DisplayVideoInfo();
        videoPython.DisplayVideoInfo();
    }
}