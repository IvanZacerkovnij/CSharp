using Homework13.Animals.Herbivores;

namespace Homework13.Animals.Carnivores;

public abstract class Carnivore
{
    public double Power { get; protected set; }

    public Carnivore(double power)
    {
        Power = power;
    }
    
    public abstract void Eat(Herbivore herbivore);
}