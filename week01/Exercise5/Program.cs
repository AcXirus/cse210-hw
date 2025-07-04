using System;
using System.Runtime.InteropServices;

class Program
{
    //IN THE MAIN FUNCTION CALL THE FUNCTION 
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();

        int sqNumber = SquareNumber(userNumber);

        DisplayResult(sqNumber, name);
    }

    // CREATE THE FUNCTION AND THEIR CODE 
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string fullName = Console.ReadLine();

        return fullName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int integerNumber = int.Parse(number);

        return integerNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

    }
    //DISPLAY THE IMFORMATION IN THE ANOTHER FUNCTION 
    static void DisplayResult(int square, string fullName)
    {
        Console.WriteLine($"{fullName}, the square of your number is: {square}");
    }
}