using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int squareNumber = SquareNumber(number);

        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your full name? ");
        string fullName = Console.ReadLine();
        
        return fullName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}