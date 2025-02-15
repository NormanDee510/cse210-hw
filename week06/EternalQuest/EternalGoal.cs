class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded '{_name}' and earned {_points} points!");
    }

    public override string GetDetailsString()
    {
        return $"[ ∞ ] {_name} - {_description}";
    }

    public override bool IsComplete() => false;
}