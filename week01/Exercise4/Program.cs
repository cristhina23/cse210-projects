using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 4.");


        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter a number to the list: ");
        number = int.Parse(Console.ReadLine());
        

        if (number == 0) {
            Console.WriteLine("The list is empty.");
            return;
        } else {
            numbers.Add(number);
        }

        while (number != 0) {


            Console.Write("Enter a number to the list: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) {
                break;
            }
            numbers.Add(number);
        }

        Console.Write("The sum of the list is: ");
        int total = 0;
        foreach (int num in numbers) {
            total += num;
        }
        Console.WriteLine(total);

        Console.Write("The average of the list is: ");
        double average = (double)total / numbers.Count;
        Console.WriteLine(average);

        Console.Write("The largest number in the list is: ");
        int largest = numbers[0];
        foreach (int num in numbers) {
            if (num > largest) {
                largest = num;
            }
        }
        Console.WriteLine(largest);

        Console.Write("The smallest number in the list is: ");
        int smallest = numbers[0];
        foreach (int num in numbers) {
            if (num < smallest) {
                smallest = num;
            }
        }
        Console.WriteLine(smallest);


        


    }
}