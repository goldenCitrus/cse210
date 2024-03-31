public class Date
{

    public List<List<string>> stats {get; set;}

    public Date(string Month, string Day, string Year)
    {
        // time = new DateTime();
        stats = new List<List<string>>();
        day = Day;
        month = Month;
        year = Year;
    }

    public void AddEvent(List<string> eventStats)
    {
        stats.Add(eventStats);
    }

    public string day {get; set;}
    public string month {get; set;}
    public string year {get; set;}
    public string time {get; set;}


}