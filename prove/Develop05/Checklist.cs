using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;

    public override void SetGoal()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();
        Console.Write("Enter description: ");
        _description = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("Enter how many times to complete for bonus: ");
        _target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            if (_timesCompleted == _target)
            {
                Console.WriteLine($"You completed the checklist! Earned {_points + _bonus} points!");
                return _points + _bonus;
            }
            Console.WriteLine($"You earned {_points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine("This checklist is already completed.");
            return 0;
        }
    }

    public override void Display()
    {
        string status = _timesCompleted >= _target ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) -- {_timesCompleted}/{_target} completed");
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override string SaveString() => $"Checklist|{_name}|{_description}|{_points}|{_target}|{_bonus}|{_timesCompleted}";
    public override void SetGoalFromLoad(string[] parts)
{
    _name = parts[1];
    _description = parts[2];
    _points = int.Parse(parts[3]);
    _target = int.Parse(parts[4]);
    _bonus = int.Parse(parts[5]);
    _timesCompleted = int.Parse(parts[6]);
}

}
