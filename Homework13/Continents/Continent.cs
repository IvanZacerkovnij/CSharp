using Homework13.Animals.Carnivores;
using Homework13.Animals.Herbivores;

namespace Homework13.Continents;

public abstract class Continent
{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}