using System;
using System.Diagnostics.Contracts;

public abstract class Activity
{
    protected int _TimePast;
    protected string _Date;
    protected double _Distance;
    protected double _Distancekm;
    protected double _Speed;
    protected double _Speedkm;
    protected double _Pace;
    protected double _Pacekm;


    public Activity(int time, string date, double distance)
    {
        _TimePast = time;
        _Date = date;
        _Distance = distance;
        _Distancekm = distance * 1.60934;
        _Speed = GetSpeed(distance, time);
        _Speedkm = GetSpeed(distance * 1.60934, time);
        _Pace = GetPace(time, distance);
        _Pacekm = GetPace(time, distance * 1.60934);

    }
    public abstract void GetSummary();
    public double GetSpeed(double distance, double time)
    {
         return (distance / time) * 60;
    }
    public double GetPace(int time, double distance){
        return time / distance;
    }

}