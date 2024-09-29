using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        Console.WriteLine("Welcome the scripture Memorization Program ");
        Scripture scrip1 = new Scripture();
        Reference refer1 = new Reference();
        Words sentence = new Words(scrip1.DisplayScripture());
        do{
            Console.Clear();
            Console.WriteLine(refer1);
            sentence.DisplaySentence();
            Console.WriteLine("\n\nPress enter to continue or Type quit to exit");
            a = sentence.hidewords();
            string choice = Console.ReadLine();

            if (choice == "quit")
            {
                break;
            }



        }while (a > 1); 
    }
}