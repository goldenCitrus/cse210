public class WritingAssignment : Assignment
{

    public WritingAssignment(string title, string studentName, string topic) : base(studentName, topic)
    {
        _title = title;
        _studentName = studentName;
        _topic = topic;
    }

    private string _title;

    public void GetWritingInformation()
    {
        Console.WriteLine($"{_studentName} - {_topic}\n{_title}");
    }
}