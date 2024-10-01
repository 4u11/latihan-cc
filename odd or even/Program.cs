using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        
        string input = Console.ReadLine();

        
        if (int.TryParse(input, out int number))
        {
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}
