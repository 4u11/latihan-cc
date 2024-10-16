using System;

class Program
{
    static void Main()
    {
        int[] numbers = { -10, 20, 15, -5, 8, -2, 5 };
        int? Keq = null;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                continue; 
            }

            if (Keq == null || numbers[i] > Keq) 
            {
                Keq = numbers[i]; 
            }

            if (numbers[i] % 5 == 0)
            {
                Console.WriteLine(numbers[i]); 
                return;
            }
        }

        
        if (Keq == null)
        {
            Console.WriteLine("null");
        }
        else
        {
            Console.WriteLine(Keq);
        }
    }
}