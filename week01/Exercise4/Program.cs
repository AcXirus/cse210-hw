using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise4 Project.");
        //CREATE A NEW LIST
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //ADD THE WHILE LOOP 
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter number ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        //SUM THE NUMBER INSIDE THE LIST
        int sum = 0;
        foreach (int numberList in numbers)
        {
            sum += numberList;
        }
        Console.WriteLine($"The sum is: {sum}");

        //CALCULATE THE AVERGE 
        float Average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {Average}");

        //FIND THE MAX 
        int max = numbers[0];
        foreach (int numberList in numbers)
        {
            if (numberList > max)
            {
                max = numberList;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}