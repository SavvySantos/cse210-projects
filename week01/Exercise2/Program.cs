using System;
using System.Data;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);


        string LetterGrade = "";

        if (percentage >= 90)
        {
            LetterGrade = "A";
        }
        else if (percentage >= 80)
        {
            LetterGrade = "B";
        }
        else if (percentage >= 70)
        {
            LetterGrade = "C";
        }
        else if (percentage >= 60)
        {
            LetterGrade = "D";
        }
        else
        {
            LetterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {LetterGrade}");

        if (percentage >= 70)
        {
            Console.WriteLine($"Congradulations! You passed!");
        }
        else
        {
            Console.WriteLine($"You did not pass. But don't worry! Study some more and then try again!");
        }
    }
}