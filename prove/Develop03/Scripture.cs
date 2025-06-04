
public class Scripture
{
    private string _reference;
    private List<Verse> _verses;
    private Random _random;  // Use one Random instance

    public Scripture(string reference, List<string> verseTexts)
    {
        _reference = reference;
        _verses = new List<Verse>();
        _random = new Random();

        foreach (string text in verseTexts)
        {
            _verses.Add(new Verse(text));
        }
    }

    public void HideRandomWords(int count)
    {
        foreach (Verse verse in _verses)
        {
            verse.HideRandomWords(count, _random);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference + "\n";
        foreach (Verse verse in _verses)
        {
            result += verse.GetDisplayText() + "\n";
        }
        return result;
    }

    public bool AllWordsHidden()
    {
        foreach (Verse verse in _verses)
        {
            if (!verse.AllWordsHidden())
                return false;
        }
        return true;
    }
}

