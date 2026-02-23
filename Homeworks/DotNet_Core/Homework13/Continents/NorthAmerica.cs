using Homework13.Animals.Carnivores;
using Homework13.Animals.Herbivores;

namespace Homework13.Continents;

public class NorthAmerica : Continent
{
    public override Carnivore CreateCarnivore()
    {
        Console.WriteLine("Wolf was created!");
        return new Wolf(90);
    }

    public override Herbivore CreateHerbivore()
    {
        Console.WriteLine("Bison was created!");
        return new Bison(150);
    }
}