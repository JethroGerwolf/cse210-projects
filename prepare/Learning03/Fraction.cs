using System;
using System.Diagnostics;

public class Fraction 
{
    private int _TopNumber;
    private int _BottomNumber;

    public Fraction()
    {
        _TopNumber = 1;
        _BottomNumber = 1;
    }
    public Fraction(int Top)
    
    {
        _TopNumber = Top;
        _BottomNumber = 1;
    }
    public Fraction(int Top, int Bottom)
    {
        _TopNumber = Top;
        _BottomNumber = Bottom;
    }

    public int GetTop()
    {
        return _TopNumber;
    }
    public void SetTop(int topnumber)
    {
        _TopNumber = topnumber;
    }
    public int GetBottom()
    {
        return _BottomNumber;
    }
    public void SetBottom(int bottomnumber)
    {
        _BottomNumber = bottomnumber;
    }
    public string GetFractionString()
    {
        return $"{_TopNumber}/{_BottomNumber}";
    }
    public double GetDecimalValue()
    {
        return _TopNumber / _BottomNumber;
    }
}