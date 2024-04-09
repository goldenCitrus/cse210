using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;

public class EventHandler
{

    //newEvent[0] = Date, newEvent[1] = Name, newEvent[2] = Start Time, newEvent[3] = Event Duration

    public void CreateEvent(string month, int year, Date date)
    {
        List<string> newEvent = new List<string>(); 
        //newEvent[0] = {month}-{day}-{year}, newEvent[1] = Name, newEvent[2] = Start Time, newEvent[3] = Event Duration
        int chosenDate;
        bool gimble;
        do 
        {
            Console.WriteLine("What day would you like to create an event on?\n(please enter a number)");
            string temp = Console.ReadLine();
            gimble = int.TryParse(temp, out chosenDate);
            if (gimble && chosenDate > 0 && chosenDate <= date.validDays)
            {
                newEvent.Add($"{date.month}-{temp}-{date.year}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input '{temp}.' Please enter a valid number.");
            }
        } while (!gimble);

        

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
            string desiredFormat = "HH:mm";
            while (true)
            {
                Console.WriteLine($"What time would you like this event to start? (please enter time formatted as {desiredFormat} using 24 hour time)");
                string userInput = Console.ReadLine();

                if (userInput.Length != desiredFormat.Length)
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid format. Please use the following format: {desiredFormat}");
                    continue;
                }

                if (!Regex.IsMatch(userInput, @"^\d{2}:\d{2}$"))
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid format. Please use the following format: {desiredFormat}");
                    continue;
                }

                int hour = int.Parse(userInput.Substring(0, 2));
                int minute = int.Parse(userInput.Substring(3, 2));

                if (hour < 1 || hour > 24)
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid hour '{hour}'. Please enter a value between 01 and 24.");
                    continue;
                }

                if (minute < 0 || minute > 59)
                {
                    Console.Clear();
                    Console.WriteLine($"Invalid minute '{minute}'. Please enter a value between 00 and 59.");
                    continue;
                }
                bool isReset = false;
                while(true)
                {
                    Console.WriteLine($"You would like {newEvent[1]} to start at {userInput}? (y/n)");
                    string confirmation = Console.ReadLine().ToLower();
                    if (confirmation == "y")
                    {
                        Console.WriteLine($"{newEvent[1]} Now begins at {userInput}");
                        newEvent.Add(userInput);
                        while(true)
                        {
                            bool loop = true;
                            Console.WriteLine("How many hours does this event last?");
                            string eventLength = Console.ReadLine();
                            int eventLengthNum;
                            bool isNum = int.TryParse(eventLength, out eventLengthNum);
                            if (isNum)
                            {
                                Console.Clear();
                                int eventHour = int.Parse(newEvent[2].Substring(0, 2));
                                // Console.WriteLine($"{eventHour}{newEvent[2].Substring(2, 3)}");
                                eventHour = (eventHour + eventLengthNum) % 24;
                                string eventTo = $"{eventHour}{newEvent[2].Substring(2, 3)}";
                                Console.WriteLine($"You want {newEvent[1]} to last {eventLength} hours?\n(From {newEvent[2]} to {eventTo}) (y/n)");
                                string lastHours = Console.ReadLine().ToLower();
                                if (lastHours == "y")
                                {
                                    Console.WriteLine($"{newEvent[1]} Now starts at {newEvent[2]}, and ends at {eventTo}");
                                    newEvent.Add(eventLength);
                                    date.date.Add(newEvent);
                                    return;
                                }
                                else if (lastHours == "n")
                                {
                                    Console.Clear();
                                    // break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Invalid input '{lastHours}'");
                                    // break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"Invalid input '{eventLength}'");
                            }
                            if (loop == true)
                            {
                                break;
                            }
                        }
                    }
                    else if (confirmation == "n")
                    {
                        Console.Clear();
                        isReset = true;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Invalid input '{confirmation}'");
                    }
                }
                if (isReset == false)
                {
                break;
                }
            }
            timeFormat = true;
        }
    }

    public void ViewEvent(Date date, int month, int year, int day)
    {
        Console.Clear();
        foreach (List<string> events in date.date)
        {
            bool hasPrinted = false;
            if (events[0] == $"{month}-{day}-{year}" && !hasPrinted)
            {
                hasPrinted = true;
                Console.WriteLine($"On {date.month} {day} {year}, You have {events[1]}, Which starts at {events[2]}, and lasts for {events[3]} hour(s)"); 
            }
        }
    }

    public void SaveCalendar(Date date)
    {
        string jsonString = JsonSerializer.Serialize(date);
        File.WriteAllText("events.json", jsonString);
    }

}