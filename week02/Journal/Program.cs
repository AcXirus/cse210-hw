using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int write = 1;
        string writeVal = write.ToString();
        int display = 2;
        string displayVal = display.ToString();
        int load = 3;
        string loadVal = load.ToString();
        int save = 4;
        string saveVal = save.ToString();
        int quit = 5;
        string quitVal = quit.ToString();

        Journal journal = new Journal();

        bool whileBoolRunning = true;

        while (whileBoolRunning)
        {
            Console.WriteLine("Please select one of the following Choises:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            string response = Console.ReadLine();


            if (response == writeVal)
            {
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();                
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();

                InfoEntry newEntry = new InfoEntry
                {
                    Prompt = prompt,
                    Response = entry,
                    Date = DateTime.Now.ToString("yyyy-MM-dd")
                };
                journal.AddEntry(newEntry);
            }
            else if (response == displayVal)
            {
                journal.DisplayAll();
            }
            else if (response == loadVal)
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (response == saveVal)
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (response == quitVal)
            {
                Console.WriteLine("Quitting program...");
                whileBoolRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a numeric value from 1 to 5.");
            }           
        }
    }
}