using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        int guess = -1;
        
        while (guess != magicNumber)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Way to go! You guessed it! The correct number is {magicNumber}!");
            }
        }
    }
}