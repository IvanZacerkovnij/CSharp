namespace fileSystem;

public class People
{
    public string name { get;}
    public byte age { get; }

    public People()
    {
        name = "none";
        age = 0;
    }
    public People(string name, byte age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Name: {name}, Age: {age}";
    }
}