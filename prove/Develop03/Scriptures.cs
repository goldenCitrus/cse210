public class Scriptures
{
public string _scripture = "6. O ye house of Israel whom I have spared, how oft will I gather you as a hen gathereth her chickens under her wings, if ye will repent and return unto me with full purpose of heart.";

public List<string> test(string scripture)
{
    char[] separators = new char[] {' '};
    List<string> words = new List<string>();

    foreach(var word in scripture.Split(separators, StringSplitOptions.RemoveEmptyEntries))
    {
        words.Add(word);
    }
    return words;
}
}