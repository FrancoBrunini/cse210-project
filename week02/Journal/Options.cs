using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Options
{
    List<string> _entries = new List<string>();
    public void Write()
    {
        List<string> questions = new List<string>
{
"Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be ?"
};
        Random rnd = new Random();
        int index = rnd.Next(questions.Count);
        string question = questions[index];
        Console.WriteLine(question);
        Console.WriteLine("Write");
        string text = Console.ReadLine();
        string entry = DateTime.Now.ToString("yyyy-MM-dd HH:mm") + " - " + text;

        _entries.Add(entry);
    }
    public void Display()
    {
        if (_entries.Count > 0)
        {
            foreach (string e in _entries)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine("No entries to display.");
        }
    }
    public void Load()
    {
        Console.WriteLine("What file do you want to load?");
        string FileName = Console.ReadLine();
        if (File.Exists(FileName))
        {
            string[] FileEntries = File.ReadAllLines(FileName);
            Console.WriteLine($"The file {FileName} has been loaded ");
            foreach (string e in FileEntries)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine($"The file {FileName} hasn't been loaded");
        }

    }
    public void Save()
    {
        Console.WriteLine("How would you like to save this file? ");
        String FileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(FileName))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    }

    