using System.Diagnostics;
using System.Formats.Asn1;


public class Reflection : Activity
{
    
    public static Dictionary<string, List<string>> questions;

    public Reflection()
    {
        _activityName = "Reflection";
        _activityDesc= "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        questions = new Dictionary<string, List<string>>();
        questions.Add("Think of a time when you stood up for someone else", new List<string>() { "Did it rule?", "When's the wedding?", "Proof?", "I don't believe you.", "Okay? So what?" });
        questions.Add("Think of a time when you did something really difficult", new List<string>() { "It probably wasn't even that hard lol", "Congrats i guess?", "What, do you want a pat on the back or something?", "wow." });  
        questions.Add("Think of a time when you helped someone in need", new List<string>() { "But what if you were too pushy?", "They probably hate you.", "I'm proud of you.", "Word.", "Boooo-riiiiing!!!!" });
        questions.Add("Think of a time when you did something truly selfless", new List<string>() { "Wow Mr. Humble over here.", "Pushover...", "k.", "I bet you think you're great don't you...", "Yeah I would've done it better." });   
    }

    public void reflect()
    {
        int useNum = (int.Parse(_activityLength))*1000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string topic = GenerateTopic();
        Console.WriteLine(topic);

        bool ask = true;
    
        while (stopwatch.ElapsedMilliseconds < useNum)
        {
            while (ask == true)
            {
                List<string> animation = new List<string>() {"|", "/", "-", "\\"};
                
                for (int i = 0; i < animation.Count; i++)  
                {
                Console.Clear();
                if (stopwatch.ElapsedMilliseconds < useNum)
                {string sayit = GenerateThoughts(topic);
                Console.WriteLine(topic + " " + animation[i]);
                Console.WriteLine(sayit);
                } else {break;}
                System.Threading.Thread.Sleep(3000);
                }
                if (stopwatch.ElapsedMilliseconds > useNum)
                {
                    Console.WriteLine("Congradulations! You have completed your reflection!\nPress any key to return to the main menu");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
    }

    private string GenerateTopic()
    {
        var keys = questions.Keys.ToList();
        var randomIndex = new Random().Next(keys.Count);
        var randomKey = keys[randomIndex];
        return randomKey;
    }

    private string GenerateThoughts(string chosenKey)  
    {
      var keys = questions.Keys.ToList();
      var randomIndex = new Random().Next(keys.Count);
      var answers = questions[chosenKey];
      var randomAnswer = answers[new Random().Next(answers.Count)]; 
      return randomAnswer;
    }
}