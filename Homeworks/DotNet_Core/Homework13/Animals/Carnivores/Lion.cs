using Homework13.Animals.Herbivores;

namespace Homework13.Animals.Carnivores;

public class Lion : Carnivore
{
    public Lion(double weight) : base(weight) {}

    public override void Eat(Herbivore herbivore)
    {
        if (!herbivore.Live)
        {
            Console.WriteLine(herbivore.GetType().Name  + " is dead already!");
            return;
        }
        if (Power > herbivore.Weight)
        {
            Console.WriteLine(typeof(Lion).Name + " killed " + herbivore.GetType().Name);
            herbivore.Live = false;
            Power += 10;
        }
        else
        {
            
            Console.WriteLine(herbivore.GetType().Name + " run away from " + typeof(Lion).Name);
            Power -= 10;
        }
    }
}