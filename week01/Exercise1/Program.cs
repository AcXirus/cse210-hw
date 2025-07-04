using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        string fristname = Console.ReadLine();
        Console.Write("what is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {fristname}{lastname}");
    }
}