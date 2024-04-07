public class MyCalendar
{

    // public string month;
    // public List<Date>

    public void LoadCalander(Date date)
    {
        // Console.WriteLine($"{date.month} {date.year}");
        Console.WriteLine("Current Month");
        for (int i = 1; i <= date.validDays; i++)
        {
            bool hasEvents = false;
            int eventCount = 0;

            foreach (List<string> eventList in date.date)
            {
                if (eventList.Count > 0 && eventList[0] == i.ToString())
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