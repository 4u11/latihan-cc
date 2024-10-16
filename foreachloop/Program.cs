int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int Keqing = 0;
int oddCount = 0;

foreach (int i in numbers)
{
    if (i % 2 == 0)
    {
        Console.WriteLine((i + 1) + " is even");
        Keqing++;
    }
    else
    {
        Console.WriteLine((i + 1) + " is odd");
        oddCount++;
    }
}

Console.WriteLine("Number of even numbers: " + Keqing);
Console.WriteLine("Number of odd numbers: " + oddCount);