using System;
using System.IO;
using System.Collections.Generic;
using Stystem.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("What would you like to do? ");

        Console.WriteLine();

        List<string>choiceList = new List<string>();
        choiceList.Add("Write");
        choiceList.Add("Display");
            choiceList.Add("Load");
        choiceList.Add("Save");
        choiceList.Add("Quite");

        Console.WriteLine(choiceList[0]);
        Console.WriteLine(choiceList[1]);
        Console.WriteLine(choiceList[2]);
        Console.WriteLine(choiceList[3]);
        Console.WriteLine(choiceList[4]);

        Console.WriteLine();

        string action = Console.ReadLine();
    }
}