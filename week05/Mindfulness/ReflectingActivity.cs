using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

private List<string> _questions = new List<string>
{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    "What strengths did you discover or rely on during this experience?",
    "Was there a moment where you wanted to give up? What helped you continue?",
    "Did this experience change your perspective on anything?",
    "How would you explain this experience to someone else?",
    "If you could relive this moment, would you do anything differently?",
    "What emotions stand out when you think back on this moment?",
    "Did anyone support you during this experience? How did they help?",
    "How has this experience impacted your goals or values?",
    "What part of this experience are you most proud of?",
    "If you were to repeat this, what would you do the same?"
};


    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue...");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\n> {question}");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }
}
