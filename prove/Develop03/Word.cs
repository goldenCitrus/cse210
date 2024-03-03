public class Word
{

public bool _isFull;
public int _howMany;
public void hideWords(List<string> scriptureList, int ammountToHide, List<int> _notBools)
{
    int count = scriptureList.Count;
    Random r = new Random();
    int list_index;
    _isFull = _notBools.All(x => x == 1);
    _howMany = 0;
    int filler;
    for (int i = 0; i < ammountToHide && !_isFull; i++)
    {
        _howMany += 1;
        _isFull = _notBools.All(x => x == 1);

        do
        {
            list_index = r.Next(count);
        } while (_notBools[list_index] == 1 && !_isFull && !int.TryParse(scriptureList[list_index], out filler));

        if (_isFull)
        {
            return;
        }
        string hiding = scriptureList[list_index];
        string nowHidden = "";
        foreach (char letter in hiding)
        {
            if (char.IsLetter(letter))
            {
                nowHidden += "_";
            } else{
                nowHidden += letter;
            }
        }
        scriptureList[list_index] = nowHidden;
        _notBools[list_index] = 1;
    }
}
}