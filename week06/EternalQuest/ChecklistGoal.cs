
class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            Console.WriteLine($"You completed '{_name}' and earned {_points + _bonusPoints} points!");
        }
        else
        {
            Console.WriteLine($"You recorded progress for '{_name}' and earned {_points} points! ({_currentCount}/{_targetCount} completed)");
        }
    }

    public override string GetDetailsString()
    {
        return $"[ {(_currentCount >= _targetCount ? "X" : " ")} ] {_name} - {_description} ({_currentCount}/{_targetCount})";
    }

    public override bool IsComplete() => _currentCount >= _targetCount;
}