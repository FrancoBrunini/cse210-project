using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writing = new WritingAssignment(
            "The Causes of World War II",
            "Franco",
            "History"




        );
        MathAssignment Math = new MathAssignment("Fractions", "Roberto Rodriguez", "7.3", "8-19");

        Console.WriteLine(writing.GetWritingInformation());
        System.Console.WriteLine(Math.GetHomeWorkList());
    }
}