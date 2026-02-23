namespace Homework9.task1;

public class Play : IDisposable
{
    public string Name { get; }
    public string AuthorFullName { get; }
    public string Genre { get; }
    public DateTime DateOfRealese { get; }

    public Play(string name, string authorFullName, string genre, DateTime dateOfRealese)
    {
        Name = name;
        AuthorFullName = authorFullName;
        Genre = genre;
        DateOfRealese = dateOfRealese;
        
        Console.WriteLine($"Play: {Name} was added");
    }

    public override string ToString()
    {
        return $"Play: {Name}, Author: {AuthorFullName}, Genre: {Genre}, Date of release: {DateOfRealese}";
    }

    public void Dispose()
    {
        Console.WriteLine($"Play: {Name} was removed(Dispose)");
    }
    
    ~Play()
    {
        Console.WriteLine($"Play: {Name} was removed(Finalizer)");
    }
}