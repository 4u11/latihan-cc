using System;

public class Program
{
    public static void CalculateExponent(long number, long exponent) 
    {
        Console.WriteLine($"Calculating the power of {number}...");
        for (long power = 0; power <= exponent; power++)
            Console.WriteLine($"{number}^{power} = {(long)Math.Pow(number, power):N0} (0x{(long)Math.Pow(number, power):X})");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Input the number:");
        long number = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Input the exponent:");
        long exponent = Convert.ToInt64(Console.ReadLine());
        CalculateExponent(number, exponent);
    }
}