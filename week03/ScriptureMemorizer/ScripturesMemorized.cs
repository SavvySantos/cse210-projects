using System.IO;
using System.Linq;
using System.Collections.Generic;

public class ScripturesMemorized
{
    private List<Reference> _references;

    public ScripturesMemorized()
    {
        _references = new List<Reference>();
    }
    public void AddReference(Reference reference)
    {
        _references.Add(reference);
    }
    public void SaveReference(string fileName)
    {
        string path = Path.Combine(Environment.CurrentDirectory, fileName);
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            foreach (var reference in _references)
            {
                writer.WriteLine(reference.ToFileFormat());
            }
            Console.WriteLine("Saved!");

        }
        Console.WriteLine("");

    }
}
