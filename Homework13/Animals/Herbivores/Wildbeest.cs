namespace Homework13.Animals.Herbivores;

public class Wildbeest : Herbivore
{
    public Wildbeest(double weight): base(weight) {}

    public override void EatGrass()
    {
        Weight += 10;
    }
}