using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Welcome to calculate the average score!!! ===");
            Console.WriteLine(" ");
            Console.Write("Enter the number of assignment scores: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of Quiz: ");
            double q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of MidTerm: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of Final: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double average =  (n + q + r + f) / 4;

            Console.WriteLine("Your average score is: " + average);
            
            

        }
    }