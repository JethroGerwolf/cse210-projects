using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int count = 0;
        int count1 = 0;
        Console.Clear();
        Console.WriteLine("\nWelcome the scripture Memorization Program \n");
        Scripture scrip1 = new Scripture();
        Reference refer1 = new Reference();
        Reference reference2 = new Reference();
        Scripture script2 = new Scripture();
        Words sentence = new Words(scrip1.DisplayScripture());
        Words sentence2 = new Words(script2.DisplayScripture());
        string choice = "";
        while (a > 0) 
        {
            if(count1 == 0)
            {
        Console.WriteLine("What would you like to do?\nAdd scripture(1)\nPractice Memorizing(2)\nExit(quit)");
        choice = Console.ReadLine();
        if (choice == "quit")
            {
                a = 0;
            }
        else if (choice == "1")
        {
            Console.WriteLine("Please enter The References");
            string _newreferences = Console.ReadLine();
            reference2 = new Reference(_newreferences);
            Console.WriteLine("Please enter the scripure");
            string _newscripture = Console.ReadLine();
            script2 = new Scripture(_newscripture, reference2.ShowReference());
            sentence2 = new Words(script2.DisplayScripture());
            count = 1;
        }
        else if (choice == "2")
        {
            Console.WriteLine($"Would you like to memorized {refer1.ShowReference()}(1)");
            if (count == 1)
            {
                Console.WriteLine($"Would you like to memorized {reference2.ShowReference()}(2)");
            }
            choice = Console.ReadLine();
            if (choice == "1")
            {
            while (a > 0) 
            {
            Console.WriteLine(refer1.ShowReference());
            sentence.DisplaySentence();
            Console.WriteLine("\n\nPress enter to continue or Type quit to exit");
            sentence.hidewords();
            sentence.hidewords();
            a = sentence.hidewords();
            choice = Console.ReadLine();
            Console.Clear();
            if (choice == "quit")
            {
                a = 0;
            }
            else{
            Console.Clear();
            Console.WriteLine(refer1.ShowReference());
            sentence.DisplaySentence();
            Console.WriteLine("\n\nPress enter to continue or Type quit to exit");
            Console.ReadLine();
            }
            }
            }
            else if (choice == "2")
            {
            while (a > 0) 
            {
            Console.WriteLine(reference2.ShowReference());
            sentence2.DisplaySentence();
            Console.WriteLine("\n\nPress enter to continue or Type quit to exit");
            sentence2.hidewords();
            sentence2.hidewords();
            a = sentence2.hidewords();
            choice = Console.ReadLine();
            Console.Clear();
            if (choice == "quit")
            {
                a = 0;
            }
            else{
            Console.Clear();
            Console.WriteLine(reference2.ShowReference());
            sentence2.DisplaySentence();
            Console.WriteLine("\n\nPress enter to continue or Type quit to exit");
            Console.ReadLine();
            }
            }
            }
        }

        }
        
        

        } 

    }
}