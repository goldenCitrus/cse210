public class Journal
    {
        public string _loadName;
        public void LoadFromFile()
        {
            string[] fileContents = File.ReadAllLines(_loadName);
            foreach (string line in fileContents)
            {
                Console.WriteLine(line);
            }

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