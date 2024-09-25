using System;
using System.Data;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please input your grades: ");
      int nilai = Convert.ToInt32 (Console.ReadLine());

      if (nilai >= 85) 
{
  Console.WriteLine("Your Grade is A");
} 
else if (nilai >= 70) 
{
  Console.WriteLine("Your Grade is B");
} 
else if (nilai >= 69)
{
  Console.WriteLine("Your Grade is C");
}
else if (nilai >= 59)
{
  Console.WriteLine("Your Grade is D");
}
else if (nilai >=50)
{
  Console.WriteLine("Your Grade is E");
}
      }



    }
  }
