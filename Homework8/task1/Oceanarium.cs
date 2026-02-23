using Homework8.Animals;
using System.Collections;

namespace Homework8;

public class Oceanarium : IEnumerable<Animal>
{
    private List<Animal>  _animals = new ();
    public string Name { get; private set; }

    public Oceanarium(string name)
    {
        Name = name;
    }

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }

    public void RemoveAnimal(string animalName)
    {
        var animal = _animals.FirstOrDefault(x => x.Name == animalName);
        if (animal != null)
        {
            _animals.Remove(animal);
        }
        else
        {
            throw new Exception("Unknown animal");
        }
    }
    
    public void ShownAnimals()
    {
        Console.WriteLine($"Oceanarium: {Name} animals:");
        foreach (Animal animal in _animals)
        {
            Console.WriteLine(animal);
        }
    }
    public  IEnumerator<Animal> GetEnumerator()
    {
        return _animals.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}