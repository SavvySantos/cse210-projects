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
        Journal journal = new Journal();
        PromptGenerator journalPrompt = new PromptGenerator();
        string prompt = journalPrompt.GetRandomPrompt();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("What Would you like to do? ");

            Console.WriteLine("");

            Console.WriteLine("1. Write a Journal Entry.");
            Console.WriteLine("2. Display my Journal Entries.");
            Console.WriteLine("3. Save my Journal Entry.");
            Console.WriteLine("4. Load my Journal Entries.");
            Console.WriteLine("5. Quit");

            Console.WriteLine("");

            string response = Console.ReadLine();
            choice = int.Parse(response);
            if (choice == 1)
            {
            Console.Write("Woule you like a Journal Prompt? ");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine(prompt);
                Console.WriteLine("");
                string text = Console.ReadLine();
                journal.AddEntry(prompt, text);
            }
            else if (answer == "no")
            {
                Console.Write("Write your Journal prompt: ");
                Console.WriteLine("");
                string text = Console.ReadLine();
                journal.AddEntry("", text);
            }
            }

            else if (choice == 2)
            {
                Console.WriteLine("");
                journal.DisplayAll();
                Console.WriteLine("");
            }

            else if (choice == 3)
            {
                Console.Write("What file name would you like to save your entry in (ex: myJournal.txt)? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("");
            }

            else if (choice == 4)
            {
                Console.WriteLine("What file would you like to load? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Exiting program...");
            }

            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }

    }
}
