using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program.");

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Select a menu option: ");
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                string prompt = journal.GetRandomPrompt();
                Console.WriteLine("\nPrompt: " + prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                Entry newEntry = new Entry(date, prompt, response);
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
            }
        }
    }
}

class Entry
{
    public string date;
    public string prompt;
    public string response;

    public Entry(string date, string prompt, string response)
    {
        this.date = date;
        this.prompt = prompt;
        this.response = response;
    }

    public void Display()
    {
        Console.WriteLine("Date: " + date);
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine();
    }
}

class Journal
{
    public List<Entry> entries = new List<Entry>();
    public List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        for (int i = 0; i < entries.Count; i++)
        {
            entries[i].Display();
        }
    }

    public void SaveToFile(string filename)
    {
        StreamWriter writer = new StreamWriter(filename);
        for (int i = 0; i < entries.Count; i++)
        {
            writer.WriteLine(entries[i].date);
            writer.WriteLine(entries[i].prompt);
            writer.WriteLine(entries[i].response);
            writer.WriteLine("---"); 
        }
        writer.Close();
        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 4)
            {
                string date = lines[i];
                string prompt = lines[i + 1];
                string response = lines[i + 2];
                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
            Console.WriteLine("Journal loaded from " + filename);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

/// I have exceeded requirements by learning how to use DateTime and incorporating it into 
/// my program. I also added text to the console that confirms the filename of where the journal is saved to.