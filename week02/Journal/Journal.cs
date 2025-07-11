using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks.Dataflow;
public class Journal
{
    public List<InfoEntry> _entries = new List<InfoEntry>();

    public void AddEntry(InfoEntry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (InfoEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outfile = new StreamWriter(file))
        {
            foreach (InfoEntry entry in _entries)
            {
                outfile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    InfoEntry entry = new InfoEntry
                    {
                        Date = parts[0],
                        Prompt = parts[1],
                        Response = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}