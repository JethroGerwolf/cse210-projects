public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Every time the goal is recorded, add the points
    public override void RecordEvent()
    {
        Console.WriteLine($"You have earned {Points} points for completing the goal: {Name}.");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} - {Description} - Ongoing");
    }
}
