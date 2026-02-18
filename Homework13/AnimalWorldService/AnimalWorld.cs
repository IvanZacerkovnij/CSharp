using Homework13.Animals.Carnivores;
using Homework13.Animals.Herbivores;
using Homework13.Continents;

namespace Homework13.AnimalWorldService;

public class AnimalWorld
{
    private Herbivore _herbivore;
    private Carnivore _carnivore;

    public AnimalWorld(Continent continent)
    {
        _herbivore = continent.CreateHerbivore();
        _carnivore = continent.CreateCarnivore();
    }

    public void MealsHerbivores()
    {
        Console.WriteLine("Herbivore eating...");
        _herbivore.EatGrass();
    }

    public void NutritionCarnivores()
    {
        Console.WriteLine("Carnivore hunting...");
        _carnivore.Eat(_herbivore);
    }
}