// Fraction.cs
using System;

public class Fraction
{
    // Private fields
    private int numerator;
    private int denominator;
    
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }
    
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }
    
    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }
   
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
