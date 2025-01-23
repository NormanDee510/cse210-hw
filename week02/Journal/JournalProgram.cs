using System;

public class JournalProgram
{
    private static Journal journal = new Journal();
    private static string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public static void Main()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Journal Program");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal to a file");
        Console.WriteLine("4. Load journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
    }

    private static void WriteNewEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        var entry = new JournalEntry(prompt, response, date);
        journal.AddEntry(entry);
        Console.WriteLine("Entry saved.\nPress any key to continue...");
        Console.ReadKey();
    }

    private static void DisplayJournal()
    {
        Console.Clear();
        if (journal.Entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
        else
        {
            journal.DisplayEntries();
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private static void SaveJournal()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.\nPress any key to continue...");
        Console.ReadKey();
    }

    private static void LoadJournal()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.\nPress any key to continue...");
        Console.ReadKey();
    }
}
