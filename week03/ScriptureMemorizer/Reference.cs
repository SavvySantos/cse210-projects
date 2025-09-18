// Methods
// GetDisplayText() : String
// Possible getters and setters

// Attributes
// _book : string
// _chapter : int
// _verse : int
// _endVerse : int

using System.Collections.Concurrent;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_chapter == 0 && _verse == 0 && _endVerse == 0)
        {
            return _book;
        }
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";

        }
    }
    public string ToFileFormat()
    {
        return _book;
    }
}