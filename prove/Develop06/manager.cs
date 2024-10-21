using System;
using System.Collections.Generic;
using System.IO;

public class Manager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private bool gameloaded = false;
    private const string SaveFileName = "goals.txt";

    public void Run()
    {
        

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Completion");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Total Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordGoal();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals(); 
                    break;
                case "6":
                    LoadGoals(); 
                    break;
                case "7":
                    return;
                    
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

        private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("\nChoose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the number of times to complete this goal: ");
                int timesToComplete = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completion: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, timesToComplete, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Goal created successfully.");
        Console.WriteLine("Push enter to continue");
        Console.ReadLine();
    }

    // Record the completion of a goal
    private void RecordGoal()
    {
        Console.Clear();
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
        Console.WriteLine("Push enter to continue");
        Console.ReadLine();
    }

    // Display all goals and their status
    private void DisplayGoals()
    {
        Console.Clear();
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
        Console.WriteLine("Push enter to continue");
        Console.ReadLine();
    }

    // Display the total score
    private void DisplayScore()
    {
        Console.Clear();
        totalScore = 0;
        foreach (var goal in goals)
        {
            if (goal is SimpleGoal simpleGoal && simpleGoal.IsComplete)
            {
                totalScore += simpleGoal.Points;
            }
            else if (goal is EternalGoal)
            {
                totalScore += goal.Points;
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                totalScore += checklistGoal.Points * checklistGoal.TimesCompleted;
                if (checklistGoal.TimesCompleted == checklistGoal.TimesToComplete)
                {
                    totalScore += checklistGoal.BonusPoints;
                }
            }
        }
        
        if (1000 >= totalScore){
        Console.WriteLine($"Level 1\n{1000 - totalScore} : Exp to next Level");
        Console.WriteLine($"Total Score: {totalScore}");
        }
        else if (10000 >= totalScore){
        Console.WriteLine($"Level 2\n{10000 - totalScore} : Exp to next Level");
        Console.WriteLine($"Total Score: {totalScore}");
        }
        else if (100000 >= totalScore){
        Console.WriteLine($"Level 3\n{100000 - totalScore} : Exp to next Level");
        Console.WriteLine($"Total Score: {totalScore}");
        }
        else if (1000000 >= totalScore){
        Console.WriteLine($"Level 4\n{1000000 - totalScore} : Exp to next Level");
        Console.WriteLine($"Total Score: {totalScore}");
        }
        else if (10000000 >= totalScore){
        Console.WriteLine($"Level 5\n{10000000 - totalScore} : Exp to next Level");
        Console.WriteLine($"Total Score: {totalScore}");
        }
        else if (100000000 >= totalScore){
        Console.WriteLine($"Level MAX\n{100000000 - totalScore} : Exp to next Level");
        Console.WriteLine($"Total Score: {totalScore}");
        }
        Console.WriteLine("Push enter to continue");
        Console.ReadLine();
    }

    // Save the goals to a file
    private void SaveGoals()
    {
        Console.Clear();
        using (StreamWriter writer = new StreamWriter(SaveFileName))
        {
            foreach (var goal in goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"SimpleGoal|{simpleGoal.Name}|{simpleGoal.Description}|{simpleGoal.Points}|{simpleGoal.IsComplete}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"EternalGoal|{eternalGoal.Name}|{eternalGoal.Description}|{eternalGoal.Points}|{eternalGoal.IsComplete}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"ChecklistGoal|{checklistGoal.Name}|{checklistGoal.Description}|{checklistGoal.Points}|{checklistGoal.TimesCompleted}|{checklistGoal.TimesToComplete}|{checklistGoal.BonusPoints}");
                }
            }
        }
        Console.WriteLine("Goals saved to file.");
        Console.WriteLine("Push enter to continue");
        Console.ReadLine();
    }

    // Load the goals from a file
    private void LoadGoals()
    {
        if (gameloaded == false){
        gameloaded = true;
        Console.Clear();
        if (File.Exists(SaveFileName))
        {
            string[] lines = File.ReadAllLines(SaveFileName);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                string goalType = parts[0];

                switch (goalType)
                {
                    case "SimpleGoal":
                        var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        simpleGoal.IsComplete = bool.Parse(parts[4]);
                        goals.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        var eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        eternalGoal.IsComplete = bool.Parse(parts[4]);
                        goals.Add(eternalGoal);
                        break;

                    case "ChecklistGoal":
                        var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                        checklistGoal.TimesCompleted = int.Parse(parts[4]);
                        goals.Add(checklistGoal);
                        break;

                    default:
                        Console.WriteLine($"Unknown goal type: {goalType}");
                        break;
                }
            }

            Console.WriteLine("Goals loaded from file.");
        }
        else
        {
            Console.WriteLine("No save file found, starting with empty goals.");
        }

    }
        else {
        Console.WriteLine("You have already loaded your game.");
    }
    Console.WriteLine("Push enter to continue");
    Console.ReadLine();
    }

}
