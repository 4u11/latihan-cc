using System;

 namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the triangle");
            double Base = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height of the triangle");
            double height = Convert.ToDouble(Console.ReadLine());

            double Area;
             
            Area = Base*height*0.5; //The formula of looking for  the area of a triangle is base*height*0.5


            Console.WriteLine("The area of the triangle is " + Math.Round(Area, 2));
        }
    }
}