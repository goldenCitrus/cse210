using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static List<string> toBeSaved = new List<string>();
    static void Main(string[] args)
    {
        string[] menuOptions = {"Create Entry", "Load Entry", "Exit", "1", "2", "3"};
        string menuSelection;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


        Console.WriteLine("Welcome to the Journal. What would you like to do today?");
        do
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }
            menuSelection = Console.ReadLine();
            menuSelection = textInfo.ToTitleCase(menuSelection);
            if (Array.IndexOf(menuOptions, menuSelection) < 0)
            {
                Console.WriteLine($"Invalid input '{menuSelection}'. Please enter one of the following:");
            }
        

        if (menuSelection == "1" || menuSelection == "Create Entry") //Creating Journal Entry
        {
            string isPrompt;
            Journal entrySaver = new();
            do //Menu to ask whether or not you want a prompt
            {
                Console.WriteLine("Would you like a prompt? (y/n)");
                isPrompt = Console.ReadLine();
                isPrompt = isPrompt.ToLower();
                if (isPrompt != "y" && isPrompt != "n")
                {
                    Console.WriteLine($"Invalid input '{isPrompt}'");
                }
            } while (isPrompt != "y" && isPrompt != "n");

            if (isPrompt == "y") // yes? generate question:
            {
                QuestionGenerator getQuestion = new();
                entrySaver._prompt = getQuestion.GenerateQuestion();
                Console.WriteLine($"{entrySaver._prompt}");
            }
            else if (isPrompt == "n") // no? write whatever you'd like!
            {
                Console.WriteLine("Write whatever you'd like!");
                
            }
            entrySaver._entry = Console.ReadLine();
            string isSave; 
            do // You wanna save your entry?
            {
            Console.WriteLine("Wonderful! Would you like to save this entry? (y/n)");
            isSave = Console.ReadLine();
            isSave = isSave.ToLower();
            } while (isSave != "y" && isSave != "n");

            if (isSave == "y") // yes? Enter file name:
            {
                Console.WriteLine("What would you like to save this file as?");
                string nameOfFile = Console.ReadLine();
                entrySaver._fileName = nameOfFile;
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                toBeSaved.Add(dateText);
                toBeSaved.Add($"In response to: {entrySaver._prompt}");
                toBeSaved.Add($"You wrote: {entrySaver._entry}");
                entrySaver._textContent = toBeSaved;
                entrySaver.SaveToFile();
            }
            Console.WriteLine("Complete! Returning to main menu!\n------------------------------------------------------------");
            Console.WriteLine("Welcome to the Journal. What would you like to do today?");
        }

        else if (menuSelection == "2" || menuSelection == "Load Entry") //Loading Journal Entry to be viewed
        {

        }
        } while (menuSelection != "3" && menuSelection != "Exit");
        // Journal load = new();
        // string test = load.LoadFromFile();
        // Console.WriteLine(test);
        // QuestionGenerator question = new();
        // Console.WriteLine($"{question.GenerateQuestion()}");
    }
}