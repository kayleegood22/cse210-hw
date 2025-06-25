using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayMenu();
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Choose a choice from the menu: ");
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string input = Console.ReadLine();
        Goal newGoal = null;

        if (input == "1") newGoal = new SimpleGoal();
        else if (input == "2") newGoal = new EternalGoal();
        else if (input == "3") newGoal = new ChecklistGoal();
        else { Console.WriteLine("Invalid choice."); return; }

        newGoal.SetGoal();
        goals.Add(newGoal);
    }

    static void ListGoals()
    {
        Console.WriteLine("\n--- Goals ---");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].Display();
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal to mark as completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            score += goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        goals.Clear();
        score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            Goal goal = null;

            switch (parts[0])
            {
                case "Simple":
                    goal = new SimpleGoal();
                    goal.SetGoalFromLoad(parts);
                    break;
                case "Eternal":
                    goal = new EternalGoal();
                    goal.SetGoalFromLoad(parts);
                    break;
                case "Checklist":
                    goal = new ChecklistGoal();
                    goal.SetGoalFromLoad(parts);
                    break;
            }

            if (goal != null)
                goals.Add(goal);
        }

        Console.WriteLine("Goals loaded.");
    }
}
