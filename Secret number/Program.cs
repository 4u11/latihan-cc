using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random secret number between 1 and 100
        var random = new Random();
        var secretNumber = random.Next(1, 101);

        // Initialize the number of attempts
        var attempts = 0;
        var maxAttempts = 10;

        Console.WriteLine("Welcome to the secret number guessing game!");
        Console.WriteLine("You have 10 attempts to guess the number.");

        while (attempts < maxAttempts)
        {
            Console.Write("Enter your guess: ");
            var input = Console.ReadLine();

            // Check if the input is a valid number
            if (int.TryParse(input, out var guess))
            {
                attempts++;

                // Check if the guess is correct
                if (guess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    return;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }

                Console.WriteLine($"Attempts remaining: {maxAttempts - attempts}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine($"Game over! The secret number was {secretNumber}.");
    }
}