using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");
        scripture.DisplayScripture();
        
        // Prompting user and hide words as they press Enter
        while (!scripture.AllWordsHidden())
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            
            scripture.HideRandomWords();
            scripture.DisplayScripture();
        }

        Console.WriteLine("All words are hidden!");
    }
}

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceText, string text)
    {
        reference = new Reference(referenceText);
        words = new List<Word>();
        
        // Splitting the text into words and creating Word objects
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int index = rand.Next(words.Count);
        words[index].Hide();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        reference.Display();
        foreach (var word in words)
        {
            Console.Write(word.IsHidden() ? "____ " : word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }
}

public class Reference
{
    private string referenceText;

    public Reference(string referenceText)
    {
        this.referenceText = referenceText;
    }

    public void Display()
    {
        Console.WriteLine(referenceText);
    }
}

public class Word
{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public string GetWord()
    {
        return word;
    }
}
