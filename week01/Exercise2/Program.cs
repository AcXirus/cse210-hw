using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise2 Project.");

        //ASK THE USER THE GRADE PORCENTAGE AND CONVERT TO "INT"//
        Console.Write("What is your grade porcetange? ");
        string gradeValue = Console.ReadLine();

        // STORED Variable VALUE 
        int gradePorcentage = int.Parse(gradeValue);
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        string letter = "";

        // Add IF STATEMENT
        if (gradePorcentage >= 90)
        {
            letter = "A";
        }
        else if (gradePorcentage >= 80)
        {
            letter = "B";
        }
        else if (gradePorcentage >= 70)
        {
            letter = "C";
        }
        else if (gradePorcentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePorcentage >= A)
        {
            Console.WriteLine($"You have a {letter}");
            Console.WriteLine("Congratulation for complete this program");
        }
        else if (gradePorcentage >= B)
        {
            Console.WriteLine($"You have a {letter}");
            Console.WriteLine("Congratulation for complete this program");
        }
        else if (gradePorcentage >= C)
        {
            Console.WriteLine($"You have a {letter}");
            Console.WriteLine("Congratulation for complete this program");
        }
        else if (gradePorcentage >= D)
        {
            Console.WriteLine($"You have a {letter}");
            Console.WriteLine("Good job, but you do not have the sufficient grade to complete this program.");
        }
        else
        {
            Console.WriteLine($"You have a {letter}");
            Console.WriteLine("We are sorry, you do not meet the minimum requirements to complete this Program.");
        }


    }
}