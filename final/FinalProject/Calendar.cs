using System.Collections.Concurrent;
using Microsoft.VisualBasic;

public class MyCalendar
{

    // public string month;
    // public List<Date>

    //newEvent[0] = {month}-{day}-{year}, newEvent[1] = Name, newEvent[2] = Start Time, newEvent[3] = Event Duration


    public void LoadCalander(Date date)
    {
        while (true)
        {
            Console.Clear();
            string bonk = "empty";
            int hackle = 0;
            while (bonk != "next" && bonk != "last" && bonk != "back")
            {
                PrintCalendar(date);

                Console.WriteLine("\nType 'next' to go next month, 'last' to go to previous month, or 'back' to return to the menu\n(alternativley, enter a date to view that day's event/events)");
                bonk = Console.ReadLine().ToLower();
                if (bonk != "next" && bonk != "last" && bonk != "back")
                {
                    if (hackle >= 1 && hackle <= date.validDays)
                    {
                        Console.Clear();
                        Console.WriteLine($"Invalid input '{bonk}'");
                    }

                }
            
                if (bonk == "next")
                {
                    Console.Clear();
                    date.UpdateMonth(1, "next");
                }
                else if (bonk == "last")
                {
                    Console.Clear();
                    date.UpdateMonth(1, "last");
                }
                else if (bonk == "back")
                {
                    return;
                }
                else if (int.TryParse(bonk, out hackle))
                {
                    hackle = int.Parse(bonk);
                    EventHandler eventHandler = new EventHandler();
                    eventHandler.ViewEvent(date, date.month, date.year, hackle);
                }
            }
        }
    }

    public void PrintCalendar(Date date)
    {
        Console.WriteLine($"{date.MonthIntToString(date.month)} {date.year}");
        // Console.WriteLine("Current Month");
        for (int i = 1; i <= date.validDays; i++)
        {
            bool hasEvents = false;
            int eventCount = 0;

            foreach (List<string> eventList in date.date)
            {
                if (eventList.Count > 0 && eventList[0] == $"{date.month}-{i}-{date.year}")
                {
                    hasEvents = true;
                    eventCount++;
                }
            }

            Console.Write(hasEvents ? $"{i}{new string('*', eventCount)} " : $"{i} ");

            if (i % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }



}