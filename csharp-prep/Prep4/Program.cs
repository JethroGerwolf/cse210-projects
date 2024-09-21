using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int fun;
        do
        {
            Console.WriteLine("Enter number: ");
            string use = Console.ReadLine();
            int number1 = int.Parse(use);
            fun = number1;
            numbers.Add(fun);
        }while (fun != 0);
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        int count = numbers.Count;
        int average = sum / count;
        Console.WriteLine($"The average is: {average}");
        int large = 0;
        foreach (int number in numbers)
        {
            if (number > large)
            {
                large = number;
            }
        }
        Console.WriteLine($"The largest number is: {large}");
    }
}