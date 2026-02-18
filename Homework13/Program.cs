using Homework13.AnimalWorldService;
using Homework13.Continents;

namespace Homework13;

class Program
{
    static void Main(string[] args)
    {
        AnimalWorld africa = new AnimalWorld(new Africa());
        africa.MealsHerbivores();
        africa.NutritionCarnivores();
        africa.NutritionCarnivores();
    }
}