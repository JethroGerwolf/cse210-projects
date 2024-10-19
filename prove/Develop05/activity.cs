using System;
using System.Threading;
using System.Linq;

public abstract class Activity
{
    private string Name;
    private string Description;
    protected int Duration ;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void GetUserDuration()
    {
        // Get user input for the duration of the activity
        while (true)
        {
            Console.Write($"Enter the duration in seconds for {Name}: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int duration) && duration > 0)
            {
                Duration = duration;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.");
            }
        }
    }

    public void PauseFor(int seconds)
    {
        // Show a simple animation (spinner) during pause
        var spinner = new[] { '|', '/', '-', '\\' };
        int spinnerIndex = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.Write($"\r{spinner[spinnerIndex]}");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(1000);
            
        }
        Console.WriteLine();
    }

    public virtual void StartActivity()
    {
        // Common start message
        Console.WriteLine($"Starting {Name}: {Description}");
        GetUserDuration();
        Console.WriteLine("Get ready to begin...");
        PauseFor(5);  
    }

    public virtual void EndActivity()
    {
        // Common end message
        Console.WriteLine($"Great job! You've completed {Name}.");
        Console.WriteLine($"Duration: {Duration} seconds.");
        PauseFor(5);  // 3 seconds pause before finishing
    }
}

