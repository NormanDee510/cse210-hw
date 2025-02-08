public class ReflectionActivity : MindfulnessActivity
{
    private static string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);

        // Ask reflection questions
        foreach (var question in reflectionQuestions)
        {
            Console.Clear();
            Console.WriteLine(question);
            ShowCountdown(5); // 5 seconds to reflect
        }

        FinishActivity();
    }
}
