using System;
using System.ComponentModel;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        Date date = new Date(dt.Month, dt.Year);;
        if (File.Exists("events.json"))
        {
            string jsonFromFile = File.ReadAllText("events.json");
            date = JsonSerializer.Deserialize<Date>(jsonFromFile);
            date.ResetDate(dt.Month, dt.Year);
        }
        else
        {
            date = new Date(dt.Month, dt.Year);
        }
        // Console.WriteLine("Hello FinalProject World!");
        EventHandler eventHandler = new EventHandler();
        MyCalendar myCalendar = new MyCalendar();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n1. Create Event\n2. View Calendar\n3. Exit");
            string input = Console.ReadLine().ToLower();
            if (input == "1")
            {
                while (true)
                {
                    Console.WriteLine("What month would you like to create this event for?");
                    string month = Console.ReadLine().ToLower();
                    if (month == "january")
                    {
                        eventHandler.CreateEvent("january", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "february")
                    {
                        eventHandler.CreateEvent("february", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "march")
                    {
                        eventHandler.CreateEvent("march", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "april")
                    {
                        eventHandler.CreateEvent("april", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "may")
                    {
                        eventHandler.CreateEvent("may", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "june")
                    {
                        eventHandler.CreateEvent("june", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "july")
                    {
                        eventHandler.CreateEvent("july", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "august")
                    {
                        eventHandler.CreateEvent("august", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "september")
                    {
                        eventHandler.CreateEvent("september", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "october")
                    {
                        eventHandler.CreateEvent("october", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "november")
                    {
                        eventHandler.CreateEvent("november", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else if (month == "december")
                    {
                        eventHandler.CreateEvent("december", dt.Year, date);
                        eventHandler.SaveCalendar(date);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input '{month}'");
                    }
                }
            }
            else if (input == "2")
            {
                while (true)
                {
                    myCalendar.LoadCalander(date);
                    Console.Clear();
                    break;
                }
            }
            else if (input == "3")
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Invalid input '{input}'");
            }
        }
    }
}