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
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}