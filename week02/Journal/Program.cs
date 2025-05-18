using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.ComponentModel;

public class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
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
                Console.WriteLine("");
                Console.WriteLine("Enter your response below: ");

                Console.WriteLine("");

                string newEntry = Console.ReadLine();
                Console.WriteLine("");
                Entry anEntry = new Entry();
                anEntry._entryText = newEntry;
                anEntry._promptText = prompt;
                anEntry._date = DateTime.Now;
                myJournal.AddEntry(anEntry);
                Console.WriteLine("");
            }
            else if (userEntry == 2)
            {
                Console.WriteLine("");
                myJournal.DisplayAll();
                Console.WriteLine("");

            }

            //To exceed requirements, if the user enters the option "3", I ask for the file they would like to
            //load and have the program find that file.
            else if (userEntry == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("What file would you like to load? ");
                string readfile = Console.ReadLine();
                Journal readJournal = new Journal();
                readJournal.LoadFromFile(readfile);
            }

            else if (userEntry == 4)
            {
                {
                    Console.WriteLine("What file name would you like to save your entry in (ex: myJournal.txt? ");
                    string filename = Console.ReadLine();
                    Journal journalFile = new Journal();
                    journalFile.SaveToFile(filename);
                    Console.WriteLine("");
                    Console.WriteLine();
                    Console.WriteLine("");
                }
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