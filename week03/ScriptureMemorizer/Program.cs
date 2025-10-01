using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the Scripture Memorizer Program!");
        Console.WriteLine("");

        var scriptureGenerator = new RandomScriptures();
        Scripture randomScripture = scriptureGenerator.GetRandomScripture();
        ScripturesMemorized mastered = new ScripturesMemorized();
        string userInput = "";

        while (userInput.ToLower() != "quit" && !randomScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine(" ");

            Console.WriteLine("Hit enter to continue or type 'quit' to quit. ");
            userInput = Console.ReadLine();
            Console.WriteLine(" ");
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            randomScripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(randomScripture.GetDisplayText());
        Console.WriteLine("");

        if (randomScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Congratulations! You memorized this Scripture!");
        }

        mastered.AddReference(randomScripture.GetReference());

        Console.WriteLine("What file would you like to save the scripture reference? ");
        string fileName = Console.ReadLine();
        mastered.SaveReference(fileName);

        Console.WriteLine("Would you like to continue to another random Scripture? ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
        {
            Console.WriteLine("Please restart the program for a new scripture!");
        }

        Console.WriteLine("Thank you fo using the scripture memorizing program! Program has now ended.");
        Console.WriteLine("");
    }
}
