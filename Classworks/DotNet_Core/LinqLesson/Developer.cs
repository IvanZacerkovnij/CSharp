namespace LinqLesson;

public class Developer
{
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Position { get; set; }

    public Developer(string name,int salary,string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }

    public override string ToString()
    {
        return $"{Name}, {Salary}, {Position} ";
    }
}