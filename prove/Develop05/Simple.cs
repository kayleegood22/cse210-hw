using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public override void SetGoal()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();
        Console.Write("Enter description: ");
        _description = Console.ReadLine();
        Console.Write("Enter points: ");
        _points = int.Parse(Console.ReadLine());
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            _timesCompleted = 1;
            Console.WriteLine($"You earned {_points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }

    public override void Display()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description})");
    }

    public override bool IsComplete() => _isComplete;
    public override string SaveString() => $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    public override void SetGoalFromLoad(string[] parts)
{
    _name = parts[1];
    _description = parts[2];
    _points = int.Parse(parts[3]);
    _isComplete = bool.Parse(parts[4]);
    _timesCompleted = _isComplete ? 1 : 0;
}

}