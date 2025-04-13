// Eternal Quest - Goal Tracker
// Exceeds requirements by adding a simple level-up system and personalized messages when achieving goals

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}