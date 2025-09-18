using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        reference.SetBook("Ether");
        reference.SetChapter(12);
        reference.SetVerse(27);
        reference.SetEndVerse(28);
        Scripture scripture = new Scripture(reference,
          "27 And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them. 28 Behold, I will show unto the Gentiles their weakness, and I will show unto them that faith, hope and charity bringeth unto me—the fountain of all righteousness.");
        string userInput = "";

        Console.WriteLine("");
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hit enter to continue or type 'quit' to quit. ");
            userInput = Console.ReadLine();
            Console.WriteLine(" ");
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("Thank you fo using the scripture memorizing program! Program has now ended.");
        Console.WriteLine("");
    }
}