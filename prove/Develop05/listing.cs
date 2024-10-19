using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    ) {}

    public override void StartActivity()
    {
        base.StartActivity();
        
        Console.Clear();
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        while (futureTime > startTime)
        {
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");
            PauseFor(5);
            Console.WriteLine("Start listing items... You have 5 seconds to think.");
            PauseFor(5);
            Console.Write("List an item (or press Enter to stop): ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
            startTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndActivity();
    }
}