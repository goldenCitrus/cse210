public class Journal
    {
        public void LoadFromFile()
        {
            Console.WriteLine("What is the name of the file you would like to load?");
            string filename = Console.ReadLine();
            string fileContents = File.ReadAllText($"{filename}");
            Console.WriteLine(fileContents);
        }

        public void SaveToFile()
        {
            
        }
    }