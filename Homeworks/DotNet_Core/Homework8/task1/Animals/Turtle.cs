namespace Homework8.Animals;

public class Turtle : Animal, IAnimal
{
    public Turtle(string name, int age): base(name, age) {}

    public override string ToString()
    {
        return $"Turtle: {Name}, Age: {Age}";
    }
}