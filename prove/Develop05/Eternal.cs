using System;

public class EternalGoal : Goal
{
    public override void SetGoal()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();
        Console.Write("Enter description: ");
        _description = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        _points = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        Console.WriteLine($"You earned {_points} points!");
        return _points;
    }

    public override void Display()
    {
        Console.WriteLine($"[] {_name} ({_description}) -- Completed {_timesCompleted} times");
    }

    public override bool IsComplete() => false;
    public override string SaveString() => $"Eternal|{_name}|{_description}|{_points}|{_timesCompleted}";
    public override void SetGoalFromLoad(string[] parts)
{
    _name = parts[1];
    _description = parts[2];
    _points = int.Parse(parts[3]);
    _timesCompleted = int.Parse(parts[4]);
}


}
