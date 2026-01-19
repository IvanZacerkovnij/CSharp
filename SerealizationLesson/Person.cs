namespace SerealizationLesson;

public class Person
{
    public string name { get; set; }
    public int age  { get; set; }

    public Person()
    {
        this.name = "Default";
        this.age = 0;
    }
    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Name: {this.name}, Age: {this.age}";
    }
}