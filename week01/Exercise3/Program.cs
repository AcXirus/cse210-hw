using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is the guess number? ");
            guessNumber = int.Parse(Console.ReadLine());


            if (guessNumber == magicNumber)
            {
                Console.Write("You guessed it");
            }
            else if (guessNumber >= magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber <= magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("Number not found");
            }
        }
   }
}