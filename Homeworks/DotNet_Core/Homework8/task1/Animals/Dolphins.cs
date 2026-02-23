namespace Homework8.Animals;

public class Dolphins : Animal , IAnimal
{
    public  Dolphins(string name, int age) : base(name, age) {}

    public override string ToString()
    {
        return $"Dolphin {Name}, Age: {Age}";
    }
}