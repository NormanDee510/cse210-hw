public class ListingActivity : MindfulnessActivity
{
    private static string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);

        // Giving user time to list things
        Console.WriteLine("Start listing your thoughts:");
        DateTime startTime = DateTime.Now;
        int count = 0;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine($"Please enter item #{count + 1}:");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }

        Console.WriteLine($"You listed {count} items.");
        FinishActivity();
    }
}
