using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Carlos", "test 01");

        Console.WriteLine(assignment1.GetSumary());

        MathAssignment mathAssignment1 = new MathAssignment("Cristhina Chacon", "Multiplication", "23", "12-25");

        Console.WriteLine(mathAssignment1.GetSumary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        
        WritingAssignment writingAssignment1 = new WritingAssignment("Cristhina Cahcon", "Religion", "The book of Mormon");
        Console.WriteLine(writingAssignment1.GetSumary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}