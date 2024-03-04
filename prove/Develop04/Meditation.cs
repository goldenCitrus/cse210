using System.Diagnostics;

public class Meditation : Activity
{
    public Meditation()
    {
        _activityName = "Meditation";
        _activityDesc = "For ths activity, you will breathe and stuff. idk man you're a grown man. figurte it out.";
    }
    public void MeditationActivity()
    {
        string[] prepareMessages = new string[] {
            "Breathe",
            "Breathe.",
            "Breathe..",
            "Breathe..."
        };
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int length = (int.Parse(_activityLength))*1000;
        while (stopwatch.ElapsedMilliseconds < length)
        {
            foreach (string message in prepareMessages)
            {
                if (stopwatch.ElapsedMilliseconds < length)
                {Console.WriteLine(message);} else {break;}
                
                System.Threading.Thread.Sleep(1000);

                Console.Clear();
            }
        }
        Console.WriteLine("Congradulations! You have completed your meditation!\nPress any key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }

}