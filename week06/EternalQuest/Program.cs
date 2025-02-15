
using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    RecordEvent(manager);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Goal newGoal = null;

        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        manager.CreateGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent(GoalManager manager)
    {
        manager.DisplayGoals();
        Console.Write("Enter goal number to record event: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);
    }
}