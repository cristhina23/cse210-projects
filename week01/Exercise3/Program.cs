using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Guess the number GAME!");

        bool playing = true;
        int tries = 0;

        while (playing)
        {
            int guess = new Random().Next(1, 21); // Genera el número mágico
            int userChoise = 0; // Se inicializa en 0 como querías

            Console.Write("What is the magic number? Choose a number between 1 and 20: ");

            while (userChoise != guess)
            {
                Console.Write("What is your guess? "); // Pide un intento al usuario
                userChoise = int.Parse(Console.ReadLine()); // Lee la nueva suposición

                if (userChoise == guess) // Si el usuario adivina
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {tries} tries.");
                }
                else if (userChoise < guess) // Si el número es menor
                {
                    Console.WriteLine("Higher");
                    tries++;
                }
                else // Si el número es mayor
                {
                    Console.WriteLine("Lower");
                    tries++;
                }
            }

            Console.Write("Do you want to play again? (yes/no): "); // Pregunta si quiere jugar otra vez
            string playAgain = Console.ReadLine().ToLower(); // Lee la respuesta del usuario

            if (playAgain != "yes") // Si el usuario no quiere jugar más
            {
                playing = false;
                Console.WriteLine("Thanks for playing! See you next time.");
            }
        }

        
       
    }
}