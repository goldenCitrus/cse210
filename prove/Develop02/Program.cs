using System;

class Program
{
    static void Main(string[] args)
    {
        // Journal load = new Journal();
        // load.LoadFromFile();
        // Console.WriteLine("Hello Develop02 World!");
        QuestionGenerator question = new();
        Console.WriteLine($"{question.GenerateQuestion()}");
        // Console.ReadLine("end program");
    }
}