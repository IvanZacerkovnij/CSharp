namespace Homework8.Animals;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Animal(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
}