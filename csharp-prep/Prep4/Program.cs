using System;

class Program
{
    static void Main(string[] args)
    {
        int parsedInput;
        List<int> userInputs = new List<int>();
        do
        {
            Console.WriteLine("Enter any number above 0 to add to a list, or enter 0 to close the program!");
            string userInput = Console.ReadLine();
            parsedInput = int.Parse(userInput);

            if (parsedInput != 0)
            {
                userInputs.Add(parsedInput);
            }

        } while (parsedInput != 0);
        
        foreach (int entry in userInputs)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine($"The sum is: {userInputs.Sum()}");
        Console.WriteLine($"The average is: {userInputs.Average()}");
        Console.WriteLine($"The largest number is: {userInputs.Max()}");
    }
}