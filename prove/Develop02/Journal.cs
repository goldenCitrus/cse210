public class Journal
    {
        public string LoadFromFile()
        {
            Console.WriteLine("What is the name of the file you would like to load?");
            string filename = Console.ReadLine();
            string _fileContents = File.ReadAllText($"{filename}");
            return _fileContents;
        }


        public string _fileName;
        public string _entry;
        public string _prompt;
        public List<string> _textContent = new List<string>();
        public void SaveToFile()
        {
            File.WriteAllLines($"{_fileName}.txt", _textContent);
        }
    }