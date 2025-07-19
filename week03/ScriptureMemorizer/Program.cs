using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of available scriptures to display
        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding."),
            (new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            (new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            (new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            (new Reference("2 Timothy", 1, 7), "For God has not given us a spirit of fear, but of power and of love and of a sound mind.")
        };

        // Pick one at random 
        Random rand = new Random();
        int index = rand.Next(scriptures.Count);
        Reference reference = scriptures[index].Item1;
        string verseText = scriptures[index].Item2;

        // Create the scripture object
        Scripture scripture = new Scripture(reference, verseText);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletlyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are now hidden! Program has ended.");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
