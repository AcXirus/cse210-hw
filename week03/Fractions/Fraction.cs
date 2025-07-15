using System;
public class Fraction
{
    private int _highter;
    private int _lower;

    public Fraction()
    {
        _highter = 1;
        _lower = 1;
    }

    public Fraction(int wholeNumber)
    {
        _highter = wholeNumber;
        _lower = 1;
    }    

    public Fraction(int high, int low)
    {
        _highter = high;
        _lower = low;
    }

    public string GetFractionString()
    {
        string total = $"{_highter}/{_lower}";
        return total;
    }

    public double GetDecimalValue()
    {
        return (double)_highter / (double)_lower;
    }
}