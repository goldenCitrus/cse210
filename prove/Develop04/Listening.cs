using System.Diagnostics;

public class Listening : Activity
{
    public Listening()
    {
        _activityName = "Listening";
        _activityDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    
    public void Listen()
    {
        var questions = new List<string> {"You good?", "Be fr. You hungry?", "Peekaboo!!! Thoughts?", "Who are you grateful for today?", "what's 8+12?"};
        int count = questions.Count;
        var r = new Random();
        int list_index = r.Next(count);
        string _question = questions[list_index];

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int useNum = (int.Parse(_activityLength))*1000;
        List<string> thisWillDefinatleyWorkSmile = new List<string>();

        while (stopwatch.ElapsedMilliseconds < useNum)
        {
            Console.WriteLine(_question + "\nWrite as much as you can about this lol mode!!!!:");
            thisWillDefinatleyWorkSmile.Add(Console.ReadLine());
            Console.Clear();
        }

        Console.WriteLine($"Congradulations! You have completed your reflection! You wrote {thisWillDefinatleyWorkSmile.Count()} things!\nPress any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
    }

}