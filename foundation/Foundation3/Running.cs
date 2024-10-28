using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Running : Activity
{
    public Running (int time, string date, double distance) : base (time, date, distance)
    {}
    public override void GetSummary()
    {
        Console.WriteLine($"{_Date} Running ({_TimePast})- Distance {_Distance} miles, Speed {_Speed} mph, Pace: {_Pace} min per mile");
        Console.WriteLine($"{_Date} Running ({_TimePast})- Distance {_Distancekm:F2} km, Speed {_Speedkm:F2} kph, Pace: {_Pacekm:F2} min per km\n");
    }
}