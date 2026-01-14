using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        string sign = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int lastdigit = grade % 10;
        if (lastdigit >= 7)
        {
             sign = "+";
        }
        else if (lastdigit < 3)
        {
             sign = "-";
        }
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (grade == 100)
        {
            letter = "A";
            sign = "";
        }
        if (letter =="F")
        {
            sign = "";
        }
        Console.WriteLine($"You have a {letter + sign}");

        if (grade >= 70)
        {
            System.Console.WriteLine("You have passed the course, congratulations!");

        }
        else
        {
            System.Console.WriteLine("You need to retake the course.");
        }
    }
}