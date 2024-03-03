public class MathAssignment : Assignment
{

    public MathAssignment(string textbookSection, string problems, string studentName, string topic) : base(studentName, topic)
    {
        _problems = problems;
        _studentName = studentName;
        _textbookSection = textbookSection;
        _topic = topic;
    }

    private string _textbookSection;
    private string _problems;
    
    public void GetHomeworkList()
    {
        Console.WriteLine($"{_studentName} - {_topic}\nSection {_textbookSection} Problems {_problems}");
    }
}