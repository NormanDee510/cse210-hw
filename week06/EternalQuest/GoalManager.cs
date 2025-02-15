using System.Collections.Generic;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore = 0;

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _totalScore += _goals[index].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }
}