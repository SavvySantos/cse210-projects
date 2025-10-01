using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine("");

        Console.WriteLine("Math Assignment:");
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string nameTopic = assignment.GetSummary();
        Console.WriteLine(nameTopic);

        MathAssignment mathAssignment = new MathAssignment("Roberto", "Fractions", "7.3", "8-19");
        string math = mathAssignment.GetHomeworkList();
        Console.WriteLine(math);
        Console.WriteLine("");

        Console.WriteLine("Writing Assignment:");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II by Mary Waters");
        string writing = writingAssignment.GetWrittingInformation();
        Console.WriteLine(writing);
        Console.WriteLine("");

    }
}