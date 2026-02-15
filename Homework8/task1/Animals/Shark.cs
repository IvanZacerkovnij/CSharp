namespace Homework8.Animals;

public class Shark : Animal , IAnimal
{
    public Shark(string name, int age) : base(name, age) {}

    public override string ToString()
    {
        return $"Animal: {Name}, Age: {Age}";
    }
}