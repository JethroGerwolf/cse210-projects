using System;

class Program
{
    static void Main(string[] args)
    {
while (true)
        {
            Console.Clear();
            Console.WriteLine("Activity Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                _ => null
            };

            if (activity != null)
            {
                activity.StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice, please select between 1-4.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}