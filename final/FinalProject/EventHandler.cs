using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;

public class EventHandler
{

    public void CreateEvent(string month, string year)
    {
        int chosenDate;
        bool gimble;
        do 
        {
            Console.WriteLine("What day would you like to create an event on?\n(please enter a number)");
            string temp = Console.ReadLine();
            gimble = int.TryParse(temp, out chosenDate);
            if (gimble)
            {
                chosenDate = int.Parse(temp);
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input '{temp}.' Please enter a valid number.");
            }
        } while (!gimble);
        Date date = new Date(month, chosenDate.ToString(), year);
        List<string> newEvent = new List<string>();
        bool sure;
        do
        {
            Console.WriteLine("What would you like to call this event?");
            string eventName = Console.ReadLine();
            bool yesOrNo;
            do
            {
                Console.WriteLine($"You would like to call this event '{eventName}'? (y/n)");
                string yN = Console.ReadLine();
                if (yN.ToLower() == "y")
                {
                    Console.Clear();
                    yesOrNo = true;
                    sure = true;
                    newEvent.Add(eventName);
                }
                else if (yN.ToLower() == "n")
                {
                    Console.Clear();
                    yesOrNo = true;
                    sure = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid input '{yN}.' Please enter either 'y' or 'n'");
                    yesOrNo = false;
                    sure = true;
                }
            } while (!yesOrNo);
        } while (!sure);
        
        bool timeFormat = false;
        while (!timeFormat)
        {
            Console.WriteLine($"What time does '{newEvent[0]}' start?\n(please enter time formatted as HH/mm)");
            string startTime = Console.ReadLine();
            string desiredFormat = "HH/mm";
            if (Regex.IsMatch(startTime, "^" + desiredFormat + "$"))
            {
                timeFormat = true; 
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input '{startTime}.'");
            }
        }
    }

}