public class BreathingActivity : MindfulnessActivity
{
    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Starting breathing instructions
        int totalTime = duration;
        int halfTime = totalTime / 2;

        for (int i = 0; i < halfTime; i++)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowCountdown(halfTime);
            Console.Clear();
            Console.WriteLine("Breathe out...");
            ShowCountdown(halfTime);
        }

        FinishActivity();
    }
}
