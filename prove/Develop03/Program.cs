using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userSelection = " ";
        Scriptures scriptures = new Scriptures();
        Word words = new Word();
        Reference reference = new Reference();
        IDictionary<string, string> dictionary = scriptures.GetDictionary();
        string sessionScripture = reference.getScripture(dictionary);
        List<string> boing = scriptures.verseToList(sessionScripture);

        do
        {
            Console.WriteLine("------------------------------");
            foreach (string word in boing)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine($"\n------------------------------");
            // Console.WriteLine($"This scripture is From {reference._bookChapetr}, specifically verse(s) {reference._verse}");
            if (!words._isFull)
            {
            Console.WriteLine("\nPress 'Enter' to hide words, or type 'quit' to quit");
            userSelection = Console.ReadLine().ToLower();
            if (userSelection != "quit" && userSelection != "")
            {
                Console.Clear();
                Console.WriteLine($"Invalid input '{userSelection}'");
            }
            else if (userSelection == "")
            {
                    userSelection = "RETURN TO MENU";
                    string numPls;
                    int wordsToHide;
                    bool doesWork;

                    do {
                    Console.WriteLine("How many words would you like to hide?");
                    numPls = Console.ReadLine();
                    doesWork = int.TryParse(numPls, out wordsToHide);
                    if (!doesWork)
                    {
                        Console.WriteLine($"Invalid input '{numPls}'. Please enetr a number.");
                    }
                    } while (!doesWork);

                    words.hideWords(boing, wordsToHide, scriptures._notBools);
                    Console.Clear();
                    if (words._howMany != 0)
                    {
                    Console.WriteLine($"{words._howMany} words hidden");
                    } else {Console.WriteLine("No words hidden! Scripture memmorized!");}
            }
            } else {Console.WriteLine("\nCongratulations! You've hidden every word! press any button to quit!");
                    Console.ReadLine();
                    return;
                    }
            
            
        } while (userSelection != "quit" && userSelection != "");
    }
}