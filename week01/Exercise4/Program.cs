using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  Enter a list of numbers, type 0 when finished.");
        int number = 0;
        List<int> numbers = new List<int>();

        do
        {
            System.Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);
        int total = 0;
        int times = 0;
        int largest = numbers[0];
        int smallest = numbers[0];
        foreach (int i in numbers)
        {
            if (i != 0)
            {
                total += i;
                times += 1;
            }

            if (i != 0 && i > largest)
            {
                largest = i;
            }
            if (i != 0 && i < smallest)
            {
                smallest = i;
            }
        }
        numbers.Sort();
        float average = (float) total / times;
        System.Console.WriteLine($"The total is: {total}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The largest number is {largest}");
        System.Console.WriteLine($"The smallest number is {smallest}");
        System.Console.WriteLine($"The sorted list is: ");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);

        }

    }
}