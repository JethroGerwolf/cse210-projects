
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // When a simple goal is completed, mark it as complete and add the points
    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Congratulations! You have completed the goal: {Name} and earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal {Name} is already completed.");
        }
    }

    public override void DisplayGoal()
    {
        string status = IsComplete ? "Completed" : "Not Completed";
        Console.WriteLine($"[ ] {Name} - {Description} - {status}");
    }
}
