using System;
using System.Runtime.InteropServices;


public class CatActivity : Activity
{
    public CatActivity() : base(
        "Cat Activity",
        "This activity will help you relax by showing you a cat."
    ) {}
        public override void StartActivity()
    {
        base.StartActivity();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        while (futureTime > startTime)
        {
            Console.Clear();
        Console.WriteLine(@" 
 /\_/\  
( o.o ) 
 > ^ <  

");
Thread.Sleep(Duration * 1000);
startTime = DateTime.Now;
        }

        EndActivity();
    }
}