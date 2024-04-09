public class Date
{

    public List<List<string>> date {get; set;}
    public Dictionary<int, int> months;

    public Date(int Month, int Year)
    {
        // time = new DateTime();
        date = new List<List<string>>();
        // validDays = new List<string>();
        month = Month;
        year = Year;

        months = new Dictionary<int, int>();
        months.Add(1, 31);
        if (year % 4 == 0)
        {months.Add(2, 28);}
        else{months.Add(2, 29);}
        months.Add(3, 31);
        months.Add(4, 30);
        months.Add(5, 31);
        months.Add(6, 30);
        months.Add(7, 31);
        months.Add(8, 31);
        months.Add(9, 30);
        months.Add(10, 31);
        months.Add(11, 30);
        months.Add(12, 31);
        validDays = months[month];
    }

    public void UpdateMonth(int newMonth, string method)
    {
      // Handle month going from 1 (January) to 12 (December)
        if (method == "next")
        {
            if (month + newMonth == 13)
            {
              month = 1;
              year++;
            }
            else
            {
              month += newMonth;
            }
        }
        else if (method == "last")
        {
            if (month - newMonth <= 0)
            {
              month = 12;
              year--;
            }
            else
            {
              month -= newMonth;
            }
        }
        validDays = months[month];
    }

    public string MonthIntToString(int monthInt)
    {
        List<string> monthStrings = new List<string>(){"january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"};
        return $"{monthStrings[monthInt-1]}";
    }

    public void ResetDate(int Month, int Year)
    {
        month = Month;
        year = Year;
    }

    public string day {get; set;}
    public int month {get; set;}
    public int validDays {get; set;}
    public int year {get; set;}
    public string time {get; set;}


}