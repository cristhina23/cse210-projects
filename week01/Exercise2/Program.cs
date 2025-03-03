using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 2 ");

        Console.Write("What is your grade percentage? ");
        string noteUsuer = Console.ReadLine();
        int note = int.Parse(noteUsuer);
        string letter = "";

        if (note >= 90 && note <= 100)
        {
            if (note <= 93 && note >= 90)
            {
                letter = "A-";
            }    
            else
            {
            letter = "A";
            }
            Console.WriteLine($"Your  grade is {letter}.");
        }
        else if (note >= 80 && note < 90)
        {
            if (note <= 83 && note >= 80)
            {
                letter = "B-";
            } 
            else if (note < 90  && note >= 87)
            {
                letter = "B+";
            }   
            else
            {
            letter = "B";
            }
            Console.WriteLine($"Your  grade is {letter}.");
        }
        else if (note >= 70 && note < 80)
        {
             if (note <= 73 && note >= 70)
            {
                letter = "C-";
            } 
            else if (note < 80  && note >= 77)
            {
                letter = "C+";
            }   
            else
            {
            letter = "C";
            }
            Console.WriteLine($"Your  grade is {letter}.");
        }
        else if (note >= 60 && note < 70)
        {
             if (note <= 63 && note >= 60)
            {
                letter = "D-";
            } 
            else if (note < 70  && note >= 67)
            {
                letter = "D+";
            }   
            else
            {
            letter = "D";
            }
            Console.WriteLine($"Your  grade is {letter}.");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your  grade is {letter}.");
        }
       

        if (note >= 70)
        {
            Console.WriteLine("Congratulations!!! You passed the class. you did great!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time, but don't give up! This is just another step in your learning journey, and you have the chance to try again. Keep going—you’re capable of achieving your goals! 💪✨");
        }
    }
}