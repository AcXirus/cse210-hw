public class InfoEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public void DisplayEntry()
    {
        Console.WriteLine($"{Date} | {Prompt}");
        Console.WriteLine($"{Response}");
        Console.WriteLine();        
    }
}