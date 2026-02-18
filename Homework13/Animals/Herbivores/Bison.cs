namespace Homework13.Animals.Herbivores;

public class Bison : Herbivore
{
    public Bison(double weight) : base(weight){}

    public override void EatGrass()
    {
        Weight += 10;
    }
}