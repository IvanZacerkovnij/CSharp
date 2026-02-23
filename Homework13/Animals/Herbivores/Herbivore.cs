namespace Homework13.Animals.Herbivores;

public abstract class Herbivore
{
    public double Weight { get; protected set; }
    public bool Live { get; set; } = true;

    protected Herbivore(double weight)
    {
        Weight = weight;
    }
    
    public abstract void EatGrass();
}