using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Welcome to the Boutique's clothes store ===");
            Console.WriteLine(" ");
            Console.WriteLine("Input the T-shirts: ");
            int tShirt = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Input the Shirts: ");
            int shirt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Sweaters: ");
            int sweater = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Pants: ");
            int pant = Convert.ToInt32(Console.ReadLine());

            int Total = tShirt +  shirt + sweater + pant;
            Console.WriteLine("Total: " + Total);

            

        }
    }