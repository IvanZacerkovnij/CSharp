using Homework13.Animals.Carnivores;
using Homework13.Animals.Herbivores;

namespace Homework13.Continents;

public class Africa : Continent
{
    public override Carnivore CreateCarnivore()
    {
        Console.WriteLine("Lion was created!");
        return new Lion(120);
    }

    public override Herbivore CreateHerbivore()
    {
        Console.WriteLine("Wildbeest was created!");
        return new Wildbeest(80);
    }
}