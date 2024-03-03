public class Reference {
public string _bookChapetr;
public string _verse;
public string getScripture(IDictionary<string, string> scripturesDict)
{
    Random r = new Random();
    int randomIndex = r.Next(scripturesDict.Count);
    string randomKey = scripturesDict.Keys.ElementAt(randomIndex);
    string randomValue = scripturesDict[randomKey];
    _bookChapetr = randomKey;
    _verse = randomValue.Substring(0, 1);
    return $"{randomKey}:{randomValue}";
}
} 