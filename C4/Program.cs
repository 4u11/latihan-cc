using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Write("Plant C4? (yes/no): ");
        string plant = Console.ReadLine().Trim().ToLower();

        while (plant != "yes" && plant != "no")
        {
            Console.Write("Invalid input. Please enter 'yes' or 'no': ");
            plant = Console.ReadLine().Trim().ToLower();
        }

        if (plant == "yes")
        {
            Console.WriteLine("Planting C4....");
            int i = 10;
            while (i > 0)
            {
                Thread.Sleep(1000);
                i--;
                if (i == 0)
                {
                    Console.WriteLine("KABOOM!!!!");
                }
                else
                {
                    Console.WriteLine(i + "...");
                }
            }
        }
        else
        {
            Console.WriteLine("C4 not planted.");
        }
    }
}