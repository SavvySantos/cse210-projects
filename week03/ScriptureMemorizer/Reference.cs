// Methods
// GetDisplayText() : String
// Possible getters and setters

// Attributes
// _book : string
// _chapter : int
// _verse : int
// _endVerse : int

using System.Collections.Concurrent;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // public Reference()
    // {
    //     _book = "Ether";
    //     _chapter = 12;
    //     _verse = 27;
    //     _endVerse = 28;
    // }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string Book
    {
        get { return _book; }
    }
    public int Chapter
    {
        get { return _chapter; }
    }
    public int Verse
    {
        get { return _verse; }
    }
    public int EndVerse
    {
        get { return _endVerse; }
    }
    public void GetDisplayText()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }
}

