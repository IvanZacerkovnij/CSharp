namespace fileSystem;

public class People
{
    public string name { get; set; }
    public byte age { get; set; }

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