using System;
using System.Collections.Generic;
using System.Linq;


public class Scripture
{
    private Reference _reference;

    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        int count = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

    }

    public bool IsCompletlyHidden()
    {
        return _words.All(word => word.IsHidden());        
    }

    public string GetDisplayText()
    {
        string verseText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {verseText}";
    }
    
}