using System;
using System.Threading;

public class MindfulnessActivity
{
    protected int duration;

    // Starting message and common behavior for all activities
    public virtual void StartActivity()
    {
        Console.WriteLine("Starting mindfulness activity...");
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Pause(3); // Pausing for a few seconds to let the user prepare
    }

    // Countdown for the activity
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000); // Sleep for 1 second
        }
    }

    // Showing the completion message
    public virtual void FinishActivity()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        Pause(2);
    }

    // Helper method for pauses
    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Displaying a dot every second
        }
        Console.WriteLine();
    }
}