using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int cycle = 6;
        int rounds = _duration / cycle;

        for (int i = 0; i < rounds; i++)
        {
            Console.Write("\nInhale... ");
            ShowCountDown(3);
            Console.Write("\nExhale... ");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}
