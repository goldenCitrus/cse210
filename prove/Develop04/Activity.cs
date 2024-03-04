using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

public class Activity
{

    public Activity()
    {
        
    }
    protected string _activityName;
    protected string _activityDesc;
    protected string _activityLength;


    public void TitleAndDesc()
    {
        Console.Write($"This activity is called {_activityName}.\n----------------------\n{_activityDesc}\n----------------------\nhow long would you like to spend on {_activityName}: ");
        _activityLength = Console.ReadLine();
        loadingScreen();
    }
    protected void loadingScreen()
    {
        string[] prepareMessages = new string[] {
            "Prepare for the activity to begin",
            "Prepare for the activity to begin.",
            "Prepare for the activity to begin..",
            "Prepare for the activity to begin..."
        };
        
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds < 5000)
        {
            foreach (string message in prepareMessages)
            {
                Console.WriteLine(message);
                System.Threading.Thread.Sleep(500); // 1-second delay
                Console.Clear();
            }
        }
    }




}