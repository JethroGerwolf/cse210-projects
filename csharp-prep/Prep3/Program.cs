using System;


class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 100);
    
        Console.WriteLine("Welcome to guess the magic number! hint *1-100");

        int guessint1;
        do {
            Console.WriteLine("What is your Guess? ");
            string guess = Console.ReadLine();
            int guessint = int.Parse(guess);
            guessint1 = guessint;
            if (guessint1 > magicnumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessint1 < magicnumber)
            {
                Console.WriteLine("higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }

        }while (guessint1 != magicnumber);
    
}


}