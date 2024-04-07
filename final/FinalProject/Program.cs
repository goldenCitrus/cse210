using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        DateTime dt = new DateTime();
        Date date = new Date(dt.Month, dt.Year);
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
                        break;
                    }
                    else if (month == "february")
                    {
                        eventHandler.CreateEvent("february", dt.Year, date);
                        break;
                    }
                    else if (month == "march")
                    {
                        eventHandler.CreateEvent("march", dt.Year, date);
                        break;
                    }
                    else if (month == "april")
                    {
                        eventHandler.CreateEvent("april", dt.Year, date);
                        break;
                    }
                    else if (month == "may")
                    {
                        eventHandler.CreateEvent("may", dt.Year, date);
                        break;
                    }
                    else if (month == "june")
                    {
                        eventHandler.CreateEvent("june", dt.Year, date);
                        break;
                    }
                    else if (month == "july")
                    {
                        eventHandler.CreateEvent("july", dt.Year, date);
                        break;
                    }
                    else if (month == "august")
                    {
                        eventHandler.CreateEvent("august", dt.Year, date);
                        break;
                    }
                    else if (month == "september")
                    {
                        eventHandler.CreateEvent("september", dt.Year, date);
                        break;
                    }
                    else if (month == "october")
                    {
                        eventHandler.CreateEvent("october", dt.Year, date);
                        break;
                    }
                    else if (month == "november")
                    {
                        eventHandler.CreateEvent("november", dt.Year, date);
                        break;
                    }
                    else if (month == "december")
                    {
                        eventHandler.CreateEvent("december", dt.Year, date);
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
                    Console.Clear();
                    myCalendar.LoadCalander(date);
                    Console.WriteLine("\nPress any key to return");
                    Console.ReadKey();
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