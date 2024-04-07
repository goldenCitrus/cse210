public class Date
{

    public List<List<string>> date {get; set;}

    public Date(int Month, int Year)
    {
        // time = new DateTime();
        date = new List<List<string>>();
        // validDays = new List<string>();
        month = Month;
        year = Year;
        if (month == 1)
        {
            validDays = 31;
        }
        else if (month == 2)
        {
            if (year % 4 == 0)
            {
                validDays = 29;
            }
            else
            {
                validDays = 28;
            }
        }
        else if (month == 3)
        {
            validDays = 31;
        }
        else if (month == 4)
        {
            validDays = 30;
        }
        else if (month == 5)
        {
            validDays = 31;
        }
        else if (month == 6)
        {
            validDays = 30;
        }
        else if (month == 7)
        {
            validDays = 31;
        }
        else if (month == 8)
        {
            validDays = 31;
        }
        else if (month == 9)
        {
            validDays = 30;
        }
        else if (month == 10)
        {
            validDays = 31;
        }
        else if (month == 11)
        {
            validDays = 30;
        }
        else if (month == 12)
        {
            validDays = 31;
        }
    }

    public void AddEvent(List<string> eventStats)
    {
        date.Add(eventStats);
    }

    public string day {get; set;}
    public int month {get; set;}
    public int validDays {get; set;}
    public int year {get; set;}
    public string time {get; set;}


}