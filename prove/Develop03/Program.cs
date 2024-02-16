using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer Program");
        Scriptures testing = new Scriptures();
        List<string> boing = testing.test(testing._scripture);
        foreach (string word in boing)
        {
            Console.WriteLine(word);
        }
    }
}