using System.Xml.XPath;

public class Scriptures
{

private IDictionary<string, string> scripturesDict;

public IDictionary<string, string> GetDictionary()
{
    return scripturesDict;
}
public Scriptures()
    {
        scripturesDict = new Dictionary<string, string>();
        scripturesDict.Add("3 Nephi 10", "6 O ye house of Israel whom I have spared, how oft will I gather you as a hen gathereth her chickens under her wings, if ye will repent and return unto me with full purpose of heart.");
        scripturesDict.Add("Alma 34", "9 For it is expedient that an atonement should be made; for according to the great plan of the Eternal God there must be an atonement made, or else all mankind must unavoidably perish; yea, all are hardened; yea, all are fallen and are lost, and must perish except it be through the atonement which it is expedient should be made.");
        scripturesDict.Add("Matthew 13", "12 For whosoever hath, to him shall be given, and he shall have more abundance: but whosoever hath not, from him shall be taken away even that he hath.");
    }
public Scriptures(string multi)
    {
        scripturesDict = new Dictionary<string, string>();
        scripturesDict.Add("Alma 26", "29 And we have entered into their houses and taught them, and we have taught them in their streets; yea, and we have taught them upon their hills; and we have also entered into their temples and their synagogues and taught them; and we have been cast out, and mocked, and spit upon, and smote upon our cheeks; and we have been stoned, and taken and bound with strong cords, and cast into prison; and through the power and wisdom of God we have been delivered again. 30 And we have suffered all manner of afflictions, and all this, that perhaps we might be the means of saving some soul; and we supposed that our joy would be full if perhaps we could be the means of saving some.");
        scripturesDict.Add("Alma 12", "13 Then if our hearts have been hardened, yea, if we have hardened our hearts against the word, insomuch that it has not been found in us, then will our state be awful, for then we shall be condemned. 14 For our words will condemn us, yea, all our works will condemn us; we shall not be found spotless; and our thoughts will also condemn us; and in this awful state we shall not dare to look up to our God; and we would fain be glad if we could command the rocks and the mountains to fall upon us to hide us from his presence.");
    }

// public string _bookChapetr;
// public string _verse;
// public string getScripture()
// {
//     Random r = new Random();
//     int randomIndex = r.Next(scripturesDict.Count);
//     string randomKey = scripturesDict.Keys.ElementAt(randomIndex);
//     string randomValue = scripturesDict[randomKey];
//     _bookChapetr = randomKey;
//     _verse = randomValue.Substring(0, 1);
//     return $"{randomKey}:{randomValue}";
// }

public List<int> _notBools;

public List<string> verseToList(string scripture)
{
    char[] separators = new char[] {' '};
    List<string> words = new List<string>();
    _notBools = new List<int>();
    _notBools.Add(1);
    _notBools.Add(1);
    foreach(var word in scripture.Split(separators, StringSplitOptions.RemoveEmptyEntries))
    {
        words.Add(word);
        _notBools.Add(0);

    }
    _notBools.RemoveAt(_notBools.Count - 1);
    _notBools.RemoveAt(_notBools.Count - 1);
    return words;
}

// public int _howMany;
// public bool _isFull;
// public void hideWords(List<string> scriptureList, int ammountToHide)
// {
//     int count = scriptureList.Count;
//     Random r = new Random();
//     int list_index;
//     _isFull = _notBools.All(x => x == 1);
//     _howMany = 0;
//     int filler;
//     for (int i = 0; i < ammountToHide && !_isFull; i++)
//     {
//         _howMany += 1;
//         _isFull = _notBools.All(x => x == 1);

//         do
//         {
//             list_index = r.Next(count);
//         } while (_notBools[list_index] == 1 && !_isFull && !int.TryParse(scriptureList[list_index], out filler));

//         if (_isFull)
//         {
//             return;
//         }
//         string hiding = scriptureList[list_index];
//         string nowHidden = "";
//         foreach (char letter in hiding)
//         {
//             if (char.IsLetter(letter))
//             {
//                 nowHidden += "_";
//             } else{
//                 nowHidden += letter;
//             }
//         }
//         scriptureList[list_index] = nowHidden;
//         _notBools[list_index] = 1;
//     }
// }
}