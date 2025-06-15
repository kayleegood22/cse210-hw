

using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that have helped you this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    protected override void PerformActivity()
{
    string prompt = GetRandomPrompt();
    Console.WriteLine($"\nPrompt:\n--- {prompt} ---");
    Console.WriteLine("You will begin in:");
    ShowCountdown(3);

    Console.WriteLine("\nStart listing items. Press Enter after each item:");

    List<string> userItems = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
        Console.Write("> ");
        string input = Console.ReadLine();

        // Stop if input takes too long (time exceeded)
        if (DateTime.Now >= endTime)
        {
            break;
        }

        if (!string.IsNullOrWhiteSpace(input))
        {
            userItems.Add(input);
        }
    }

    Console.WriteLine($"\nYou listed {userItems.Count} items.");
}


    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
