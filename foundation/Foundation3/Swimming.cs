using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Swimming : Activity
{
    public Swimming (int time, string date, int laps) : base (time, date, laps * 0.05 * 0.62)
    {}
    public override void GetSummary()
    {
        Console.WriteLine($"{_Date} swimming ({_TimePast})- Distance {_Distance} miles, Speed {_Speed} mph, Pace: {_Pace:F2} min per mile");
        Console.WriteLine($"{_Date} swimming ({_TimePast})- Distance {_Distancekm:F2} km, Speed {_Speedkm:F2} kph, Pace: {_Pacekm:F2} min per km\n");
    }
}