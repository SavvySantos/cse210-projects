using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word();
        Scripture scripture = new Scripture();
        string userInput = "";

        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("");

        while (userInput != "quit")
        {
            Console.WriteLine("Hit enter to continue or type 'quit' to quit. ");
            userInput = Console.ReadLine();
            Console.WriteLine("");

            if (userInput != "quit")
            {
                Reference scriptureReference = new Reference("Ether", 12, 27, 28);

                Console.WriteLine("");

                scriptureReference.GetDisplayText();

                Console.WriteLine("");
            }
        }
    }
}