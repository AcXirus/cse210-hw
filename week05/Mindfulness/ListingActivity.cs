using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
    "What are three things that made you smile today?",
    "What are some goals you are proud of achieving?",
    "Who has had a positive impact on your life?",
    "What talents or skills are you grateful to have?",
    "What are some moments when you felt truly peaceful?",
    "What challenges have you overcome recently?",
    "What blessings have you noticed this week?",
    "Who do you admire for their kindness or courage?",
    "What are some things you love about nature?",
    "What opportunities do you have that you are thankful for?",
    "What spiritual experiences have strengthened your faith?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> entries = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                entries.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {entries.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
