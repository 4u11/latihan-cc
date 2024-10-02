using System;

namespace IMT
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height");
            double height = Convert.ToDouble(Console.ReadLine());
            double IMT;
            IMT = weight / Math.Pow(height / 100, 2);
            if (IMT < 18.5)
            {
                Console.WriteLine("you are underweight");
            }
            else if (IMT >= 18.5 && IMT <= 24.9)
            {
                Console.WriteLine("your body weight is normal");
            }
            else if (IMT >= 25.0 && IMT <= 29.9)
            {
                Console.WriteLine("You are overweight");
            }
            else if (IMT >= 30.0)
            {
                Console.WriteLine("You are an obese person, please immediately go to doctor");
            }
        }
    }
}