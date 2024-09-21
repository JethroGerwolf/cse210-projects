using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello what grade are we looking at today?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter;
        if (number >= 90)
        {
            letter = ("A");
    
        }
        else if (number >= 80)
        {
            letter = ("B");
        }
        else if (number >= 70)
        {
            letter = ("C");
        }
        else if (number >= 60)
        {
            letter = ("D");
        }
        else 
        {
            letter = ("F");
        }
        Console.WriteLine($"Your grade is {letter}");
        if (number >= 70)
        {
            Console.WriteLine("Congrats you are passing your class");

        }
        else 
        {
            Console.WriteLine("Oh NO! Your are failing please work harder and not play so many video games");
            
        }

    }
}