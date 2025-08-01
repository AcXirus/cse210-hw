using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===\n");
            Console.WriteLine("Welcome to the Mindfulness Program.");
            Console.WriteLine("This program is designed to help you relax, focus, and become more present.");
            Console.WriteLine("You will be guided through a series of short activities to improve your mental well-being.");
            Console.WriteLine("Choose an activity below to begin:\n");

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nChoose an option 1 - 4: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ListingActivity().Run();
                    break;
                case "3":
                    new ReflectingActivity().Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
