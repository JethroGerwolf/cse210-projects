public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; set; }  // Change this to public

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    // Method to record an event (accomplishment) for the goal
    public abstract void RecordEvent();

    // Method to display the goal status
    public abstract void DisplayGoal();
}

 