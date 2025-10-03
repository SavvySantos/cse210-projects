using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("");

        Activity activity = new Activity("Generic", "Generic description");
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Chose an activity:");
            Console.WriteLine("");

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listening Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");

            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run(); //Note to self: This is how to call a 'void' function from another class.
            }
            else if (choice == 2)
            {
                ListeningActivity listeningActivity = new ListeningActivity();
                listeningActivity.Run();
            }

            else if (choice == 3)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (choice == 4)
            {
                Console.WriteLine("Come back soon!");
                Console.WriteLine("");
            }
        }
    }
}