using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        bool menu = true;

        while (menu == true)
        {
            Console.WriteLine("Activities:\n1. Meditation\n2. Reflection\n3. Listening\n4. Exit");
            Console.WriteLine("What activity would you like to do?");
            string chosenActivity = Console.ReadLine().ToLower();
            // string safer = chosenActivity.ToLower();
            if (chosenActivity == "meditation")
            {
                Console.Clear();
                // Activity activity = new Activity(chosenActivity);
                // activity.TitleAndDesc();
                Meditation meditation = new Meditation();
                meditation.TitleAndDesc();
                meditation.MeditationActivity();

                Console.Clear();
            }
            else if (chosenActivity == "reflection")
            {
                Console.Clear();

                Reflection reflection = new Reflection();
                reflection.TitleAndDesc();
                reflection.reflect();

                Console.Clear();
            }
            else if (chosenActivity == "listening")
            {
                Console.Clear();

                Listening listening = new Listening();
                listening.TitleAndDesc();
                listening.Listen();

                Console.Clear();
            }
            else if (chosenActivity == "exit")
            {
                menu = false;
            }
            else {Console.Clear();Console.WriteLine($"Invalid input {chosenActivity}");}
        }
    }
}