using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
        string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
        int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }
        int SquareNumber(int first)
    {
        int Square = first * first;
        return Square;
    
    }
        static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int square = SquareNumber(number);
    DisplayResult(name, square);


    }
}