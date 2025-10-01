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

    public Scripture(string reference, string scripture)
    {
        (string book, int chapter, int verse, int endVerse) = ParseReferenceString(reference);
        _reference = new Reference(book, chapter, verse, endVerse);

        _words = new List<Word>();
        string[] scriptureWords = scripture.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var scriptureWord in scriptureWords)
        {
            _words.Add(new Word(scriptureWord));
        }
    }

    private (string book, int chapter, int verse, int endVerse) ParseReferenceString(string reference)
    {
        string book = "";
        int chapter = 0;
        int verse = 0;
        int endVerse = 0;

        var parts = reference.Trim(':');
        string fullReference = parts;

        var bookSpaceChapter = fullReference.LastIndexOf(' ');
        if (bookSpaceChapter > 0)
        {
            book = fullReference.Substring(0, bookSpaceChapter);
            // if (!int.TryParse(bookChapter.Substring(bookSpaceChapter + 1), out chapter))
            //{

            //}
        }

        if (parts.Length > 1)
        {
            endVerse = verse;
            //var verseParts = parts.Trim().Split('-');
        }
        else
        {
            endVerse = verse;
        }
        return (book, chapter, verse, endVerse);

    }
}