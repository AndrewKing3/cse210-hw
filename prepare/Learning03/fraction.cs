using System;
using System.Data;




class Fraction
{
    
    private int _numerator;

    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;

        _denomenator = 1;
    }

    public Fraction(int numerator, int denomenator)
    {
        _numerator = numerator;

        _denomenator = denomenator;

    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenomenator()
    {
        return _denomenator;
    }

    public void SetDenomenator(int denomenator)
    {
        _denomenator = denomenator;
    }

    public string GetFractionString()
    {
        String strFraction  = ($"{_numerator}/{_denomenator}");

        return strFraction;

    }

    public double GetDecimalValue()
    {
        double dbFraction = (double)_numerator/(double)_denomenator;
        return dbFraction;
    }

}
