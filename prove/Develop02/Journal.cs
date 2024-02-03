public class Journal
    {
        public string LoadFromFile()
        {
            Console.WriteLine("What is the name of the file you would like to load?");
            string filename = Console.ReadLine();
            string _fileContents = File.ReadAllText($"{filename}");
            return _fileContents;
        }

        public void SaveToFile()
        {
            
        }
    }