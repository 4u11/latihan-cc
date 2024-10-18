using System;
class Program
{
    static  void Main()
    {

    


Console.WriteLine("---Hello and Welcome to Miftahul's Shape Calculator---");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("---Choose your shape to begin!---");
Console.WriteLine("1. Circle");
Console.WriteLine("2. Square");
Console.WriteLine("3. Rectangle");
int slc = Convert.ToInt32(Console.ReadLine());
    if (slc == 1)
{
    Console.WriteLine("You has been chosen the circle");
    Console.WriteLine("Choose the Calculation:");
    Console.WriteLine("1. Area");
    Console.WriteLine("2. Perimeter");
    int slccrl =  Convert.ToInt32(Console.ReadLine());
    if (slccrl == 1)
    {
        Console.WriteLine("Choose which  unit you want to use for the radius:");
        Console.WriteLine(" 1. Centimeter");
        Console.WriteLine(" 2. Meter");
        int  slccrll = Convert.ToInt32(Console.ReadLine());
        if (slccrll == 1)
        {
            Console.WriteLine("Choose the thing that known:");
            Console.WriteLine("1. Radius");
            Console.WriteLine("2. Diameter");
            int slccrlll = Convert.ToInt32(Console.ReadLine());
            if  (slccrlll == 1)
            {
                Console.WriteLine("Enter the radius in centimeter:");
                double r = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("The area of the circle is " + area + " cm^2");
            }
            else if (slccrlll == 2)
            {
                Console.WriteLine("Enter the diameter in centimeter");
                double r = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * (r / 4);
                Console.WriteLine("The area of the circle is " + area + " cm^2");
            }
            else{
                Console.WriteLine("The Choice is wrong. You're not excuse");
            }

        }
        else if (slccrll == 2)
        {
            Console.WriteLine("Choose the thing that known:");
            Console.WriteLine("1. Radius");
            Console.WriteLine("2. Diameter");
            int slccrlll = Convert.ToInt32(Console.ReadLine());
            if  (slccrlll == 1)
            {
                Console.WriteLine("Enter the radius in Meter:");
                double r = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("The area of the circle is " + area + " m^2");
            }
            else if (slccrlll == 2)
            {
                Console.WriteLine("Enter the diameter in Meter");
                double r = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * (r / 4);
                Console.WriteLine("The area of the circle is " + area + " m^2");
            }
            

        }

    }
    else if  (slccrl == 2)
    {
        Console.WriteLine("Choose which unit will be used");
        Console.WriteLine("1. Centimeter");
        Console.WriteLine("2. Meter");
        int slccrll = Convert.ToInt32(Console.ReadLine());
        if (slccrll == 1)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double r = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("The perimeter of the circle is: " + perimeter +  " cm");

        }
        if  (slccrll == 2)
        {
            Console.WriteLine("Enter the radius of the circle:");
        double r = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("The perimeter of the circle is: " + perimeter + " M");
        }
        else
        {
            Console.WriteLine("Your choices is wrong. I'm not sorry.");
        }

    }
    else
    {
        Console.WriteLine("Invalid choice, choose between the 1 or 2 no more no less");
    }

}
else if (slc == 2)
{
    Console.WriteLine("You has been chosen the square");
    Console.WriteLine("Choose the calculation:");
    Console.WriteLine("1. Area");
    Console.WriteLine("2. Perimeter");
    int slccsq = Convert.ToInt32(Console.ReadLine());
    if (slccsq == 1)
    {
        Console.WriteLine("Choose which unit will be used in this scenario");
        Console.WriteLine("1. Centimeter");
        Console.WriteLine("2. Meter");
        Console.WriteLine("3. Kilometer");
        int  slccsq1 = Convert.ToInt32(Console.ReadLine());
        if (slccsq1 == 1)
        {
            Console.WriteLine("Enter the side of the square in Centimeter:");
            double l = Convert.ToDouble(Console.ReadLine());
            double area = (l *  l);

            Console.WriteLine("The area of the square is: "  + area + " cm^2");
        }
        else if (slccsq1 == 2)
        {
            Console.WriteLine("Enter the side of the square in Meter:");
            double l = Convert.ToDouble(Console.ReadLine());
            double area = (l *  l);

            Console.WriteLine("The area of the square is: " + area + " m^2");
        }
        else if (slccsq1 == 3)
        {
            Console.WriteLine("Enter the side of the square in Kilometer:");
            double l = Convert.ToDouble(Console.ReadLine());
            double area = (l * l);
            Console.WriteLine("The area of the square is: " + area + " km^2");
        }
        else
        {
            Console.WriteLine("Invalid input! Choose correctly!!!");
        }


        
    }
    else if (slccsq == 2)
    {
        Console.WriteLine("Choose which unit will be used in this scenario");
        Console.WriteLine("1. Centimeter");
        Console.WriteLine("2. Meter");
        Console.WriteLine("3. Kilometer");
        int  slccsq11 = Convert.ToInt32(Console.ReadLine());
        if (slccsq11 == 1)
        {
            Console.WriteLine("Enter the perimeter of the square in Centimeter:");
            double p = Convert.ToDouble(Console.ReadLine());
            double s = 4 * p;
            Console.WriteLine("The Perimeter of the square is:  " + s + " cm");

        }
        else if (slccsq11 == 2)
        {
            Console.WriteLine("Enter the side of the square in Meter:");
            double  p = Convert.ToDouble(Console.ReadLine());
            double s = 4 *  p;
            Console.WriteLine("The Perimeter of the square is: " + s + " m");
        }
        else if  (slccsq11 == 3)
        {
            Console.WriteLine("Enter the side of the square in Kilometer:");
            double p = Convert.ToDouble(Console.ReadLine());
            double s = 4 * p;
            Console.WriteLine("The Perimeter of the square is: " + s + " km");
        }
        else
        {
            Console.WriteLine("Invalid input! If you have eyes your input would be correct");
        }

        
    }
    else
    {
        Console.WriteLine("The only input was between  1 and 2. Not  more than that or even less than that");


    }
}
else if (slc == 3)
{
    Console.WriteLine("You has been chosen the rectangle");
    Console.WriteLine("Choose the calculation:");
    Console.WriteLine("1. Area");
    Console.WriteLine("2. Perimeter");
    int slccr = Convert.ToInt32(Console.ReadLine());
    if (slccr == 1)
    {
        Console.WriteLine("Choose which unit will be choosen in this scenario");
        Console.WriteLine("1. Centimeter");
        Console.WriteLine("2. Meter");
        Console.WriteLine("3. Kilometer");
        int  slccsq111 = Convert.ToInt32(Console.ReadLine());
        if  (slccsq111 == 1)
        {
            Console.WriteLine("Input the length");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the width");
            double w = Convert.ToDouble(Console.ReadLine());
            double area = l * w;
            Console.WriteLine("The area of the rectangle is: " + area + " cm");
        }
        else if (slccsq111 == 2)
        {
            Console.WriteLine("Input the length");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the width");
            double w = Convert.ToDouble(Console.ReadLine());
            double area = l * w;
            Console.WriteLine("The area of the rectangle is: " + area + " m");
        }
        else if (slccsq111 == 3)
        {
            Console.WriteLine("Input the length");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the width");
            double w = Convert.ToDouble(Console.ReadLine());
            double area = l * w;
            Console.WriteLine("The area of the rectangle is: " + area + " km");
        }
        else
        {
            Console.WriteLine("Invalid input!  Please choose a valid unit.");

        }


    }
    else if (slccr == 2)
    {
        Console.WriteLine("Choose which unit will be choosen in this scenario");
        Console.WriteLine("1. Centimeter");
        Console.WriteLine("2. Meter");
        Console.WriteLine("3. Kilometer");
        int  slccsq222 = Convert.ToInt32(Console.ReadLine());
        if  (slccsq222 == 1)
        {
            Console.WriteLine("Input the length");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the width");
            double w = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (l + w);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter + " cm");
        }
        else if  (slccsq222 == 2)
        {
            Console.WriteLine("Input the length");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the width");
            double w  = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (l + w);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter + " m");
        }
        else if (slccsq222 == 3)
        {
            Console.WriteLine("Input the length");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the width");
            double w = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (l + w);
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter + " km");
        }
        else
        {
            Console.WriteLine("Invalid input!  Please choose a valid unit. hmmmm!!!!");
        }

    }
    else
    {
        Console.WriteLine("Invalid input! Please...input a valid choice");

    }
}
else 
{
    Console.WriteLine("First mistake, second mistakes will be diabolical");
}
    }
}