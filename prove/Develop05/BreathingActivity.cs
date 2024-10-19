using System;
using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    ) {}
    private void hold(int sec)
    {
    Console.Clear();
    for (int i = 0; i < sec; i++)
    {

    Console.Write($"{i+1}");

    Thread.Sleep(1000);

    Console.Write("\b"); 
    }
    Console.Write(""); 

    }
    public override void StartActivity()
    {
        base.StartActivity();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        while (futureTime > startTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            hold(4);
            Console.WriteLine("Breathe out...");
            hold(4);
            startTime = DateTime.Now;
        }

        EndActivity();
    }
}