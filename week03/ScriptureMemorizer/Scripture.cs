// Methods
// HideRandomWords(numberToHide : int) : void
// GetDisplayText() : string
// IsCompletelyHidden() : bool

// Attributes
// _reference : Reference
// _words : List<Word>

using System.Reflection.Metadata.Ecma335;
using System;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _words = new List<Word>();
        var scriptureWords = scripture.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (var scriptureWord in scriptureWords)
        {
            _words.Add(new Word(scriptureWord));
        }
    }

    public string GetScriptureText()
    {
        return string.Join(" ", _words.Select(word => word.GetScripture()));
    }

    public override string ToString()
    {
        return GetScriptureText();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random _random = new Random();
        var notHidden = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && notHidden.Count > 0; i++)
        {
            int index = _random.Next(notHidden.Count);
            notHidden[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(_words => _words.IsHidden());
    }
}