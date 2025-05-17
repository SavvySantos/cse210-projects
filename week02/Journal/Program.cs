using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator journalPrompt = new PromptGenerator();
        int userEntry = 0;
        
        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to your Journal!");
        
        while(userEntry != 5)
        {
            Console.WriteLine("What Would you like to do? ");

            Console.WriteLine("");
            
            Console.WriteLine("1. Write a Journal Entry.");
            Console.WriteLine("2. Display my Journal Entry.");
            Console.WriteLine("3. Load my Journal Entries.");
            Console.WriteLine("4. Save my Journal Entry.");
            Console.WriteLine("5. Quit");

            Console.WriteLine("");

            string response = Console.ReadLine();
            userEntry = int.Parse(response);

            if (userEntry == 1)
            {
                string prompt = journalPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.WriteLine();
                Console.WriteLine("Enter your response below: ");

                Console.WriteLine("");

                string newEntry = Console.ReadLine();
                anEntry._entryText = newEntry;
                anEntry._promptText = prompt;
                myJournal.AddEntry(newEntry);
                Console.WriteLine("");
            }
            else if (userEntry == 2)
            {
                Console.WriteLine("");
                anEntry.Display();
                Console.WriteLine("");

            }
            //how do I get information from a file C# (google.com) streamreader
            //highlight section to comment out = ctrl + kc = comments whole section ctrl + ku = uncomments
            else if (userEntry == 3)
            {
                Console.WriteLine("");
                myJournal.DisplayAll();
            }

            else if (userEntry == 4)
            {
                myJournal.SaveToFile($"{myJournal}");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            else if (userEntry == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Thank you! Have a great day!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("I'm sorry, I do not understand. Please try again.");
                Console.WriteLine("");
            }
        }
    }
}