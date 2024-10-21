public class ChecklistGoal : Goal
{
    public int TimesToComplete { get; set; }
    public int TimesCompleted { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusPoints)
        : base(name, description, points)
    {
        TimesToComplete = timesToComplete;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (TimesCompleted < TimesToComplete)
        {
            TimesCompleted++;
            int pointsEarned = Points;
            Console.WriteLine($"You have earned {pointsEarned} points for completing goal: {Name}.");
            
            if (TimesCompleted == TimesToComplete)
            {
                pointsEarned += BonusPoints;
                Console.WriteLine($"Congratulations! You completed the checklist goal and earned an additional {BonusPoints} bonus points. Total: {pointsEarned}");
            }
        }
        else
        {
            Console.WriteLine($"Goal {Name} has already been completed.");
        }
    }

    public override void DisplayGoal()
    {
        string status = TimesCompleted == TimesToComplete ? "Completed" : $"Completed {TimesCompleted}/{TimesToComplete} times";
        Console.WriteLine($"[ ] {Name} - {Description} - {status}");
    }
}
