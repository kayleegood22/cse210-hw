

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _timesCompleted;



    public Goal()
    {
        _timesCompleted = 0;
    }

    public abstract void SetGoal();
    public abstract int RecordEvent();
    public abstract void Display();
    public abstract bool IsComplete();
    public abstract string SaveString();
    public abstract void SetGoalFromLoad(string[] parts);



}