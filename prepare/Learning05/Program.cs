using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("maximilian the great", "addition");
        Console.WriteLine(a1.Getsummery());

        
        MathAssignment a2 = new MathAssignment("Kyla laswell", "multi", "10", "problem 12");
        Console.WriteLine(a2.Getsummery());
        Console.WriteLine(a2.GetHomeworkList());
        //please forgive the bad spellings
        WritingAssignment a3 = new WritingAssignment("mama dear", "science ", "How to make crapys");
        Console.WriteLine(a3.Getsummery());
        Console.WriteLine(a3.GetWritingInformation());
    }
}