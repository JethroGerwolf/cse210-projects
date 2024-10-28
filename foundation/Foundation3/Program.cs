using System;
using System.Runtime.CompilerServices;

class Program
{
    private List<Activity> _WorkoutDone = new List<Activity>();
    static void Main(string[] args)
    {
        Program program = new Program(); 
        program._WorkoutDone.Add(new Running(30, "10 Oct 2024", 10.0));
        program._WorkoutDone.Add(new Bycycling(60, "11 Oct 2024", 10.0));
        program._WorkoutDone.Add(new Swimming(30, "12 Oct 2024", 5));
        foreach (var activity in program._WorkoutDone)
        {
            activity.GetSummary();
        }
    }
}