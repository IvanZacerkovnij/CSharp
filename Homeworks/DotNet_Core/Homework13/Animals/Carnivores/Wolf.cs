using Homework13.Animals.Herbivores;

namespace Homework13.Animals.Carnivores;

public class Wolf : Carnivore
{
    public Wolf(double power) :  base(power) {}
    
    public override void Eat(Herbivore herbivore)
    {
        if (!herbivore.Live)
        {
            Console.WriteLine(herbivore.GetType().Name + " is dead already!");
            return;
        }
        if (Power > herbivore.Weight)
        {
            Console.WriteLine(typeof(Wolf).Name + " killed " + herbivore.GetType().Name);
            herbivore.Live = false;
            Power += 10;
        }
        else
        {
            
            Console.WriteLine(typeof(Herbivore).Name + " run away from " + herbivore.GetType().Name);
            Power -= 10;
        }
    }
}