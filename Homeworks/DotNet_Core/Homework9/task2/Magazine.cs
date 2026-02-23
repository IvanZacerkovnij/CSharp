namespace Homework9.task2;

public class Magazine : IDisposable
{
    public string Name { get; }
    public string Adress { get; }
    public MagazineType Type { get; }

    public Magazine(string name, string adress, MagazineType type)
    {
        Name = name;
        Adress = adress;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Name}, {Type}, {Adress}";
    }

    public void Dispose()
    {
        Console.WriteLine($"Magazine: {Name} was deleted(Dispose)");
    }
    ~Magazine()
    {
        Console.WriteLine($"Magazine: {Name} was deleted(Finalizer)");
    }
    
}