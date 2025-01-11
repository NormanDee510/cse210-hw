using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        Console.WriteLine("Welcome to the Guess My Number game!");

        while (playAgain)
        {
            
            int magicNumber = random.Next(1, 101);

            Console.WriteLine("\nI have selected a magic number between 1 and 100. Try to guess it!");

            int guess = 0; 
            int attempts = 0; 
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out guess))
                {
                    attempts++; 

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                        Console.WriteLine($"It took you {attempts} attempts to guess correctly.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
            
            Console.Write("\nDo you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing! Goodbye!");
            }
        }
    }
}