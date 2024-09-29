using System;

class Program
{
    static void Main(string[] args)
    {
        int an = 1;
        Console.WriteLine("Hello and welcome to the Journal program");
        Journal journal1 = new Journal();
        
        do 
        {
            
            Console.WriteLine("What would you like to do?\nWrite Entry(1):\nDisplay(2):\nSave(3):\nLoad(4):\nExit(5):");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                

                Console.WriteLine("Would you like a prompt today?\nYes (1): \nNo (2):");
                string choise = Console.ReadLine();
                if (choise == "1")
                {
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                Prompt prompt1 = new Prompt();
                string newprompt = prompt1.randomprompt();
                Console.WriteLine(newprompt);
                string answer = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = newprompt;
                newEntry._entry = answer;

                journal1._entry.Add(newEntry);
                }
                else {
                Prompt prompt1 = new Prompt();
                string newprompt = " ";
                string answer = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = newprompt;
                newEntry._entry = answer;

                journal1._entry.Add(newEntry);
                }

            }
            else if (choice == "2")
            {
                Console.WriteLine("\n");
                journal1.Displayjournal();
                Console.WriteLine("\n");
            }
            else if (choice == "3")
            {
                if (journal1.Load_file == 1)
                {
                journal1.SaveFile();
                Console.WriteLine($"Save was successful. The file is called \"{journal1._fileName}\"");
                }
                else{
                Console.WriteLine("What do you want to be the name of your file?:");
                string answer = Console.ReadLine();
                journal1._fileName = answer;
                journal1.SaveFile();
                Console.WriteLine($"Save was successful. The file is called \"{journal1._fileName}\"");
                }
            }
            else if(choice == "4")
            {
                journal1.Load_file = 1;
                Console.WriteLine("What is the name of the file you would like to load?:");
                string answer = Console.ReadLine();
                journal1._fileName = answer;
                journal1.LoadFile();
            }
            else if (choice == "5")
            {

               break;
            }





        }while (an == 1);
    }
}