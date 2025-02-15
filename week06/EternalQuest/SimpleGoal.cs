class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You completed '{_name}' and earned {_points} points!");
    }

    public override string GetDetailsString()
    {
        return $"[ {( _isComplete ? "X" : " " )} ] {_name} - {_description}";
    }

    public override bool IsComplete() => _isComplete;
}