
public class Verse
{
    private List<Word> _words;

    public Verse(string verseText)
    {
        _words = new List<Word>();

        string[] parts = verseText.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int count, Random rand)
    {
        int hidden = 0;

        // Make a list of visible word indexes
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                visibleIndexes.Add(i);
        }

        // Shuffle and hide up to 'count' words
        while (hidden < count && visibleIndexes.Count > 0)
        {
            int randIndex = rand.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randIndex];
            _words[wordIndex].Hide();
            visibleIndexes.RemoveAt(randIndex);
            hidden++;
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}

