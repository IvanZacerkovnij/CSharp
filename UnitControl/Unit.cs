namespace UnitControl;

public class Unit
{
    private const int MaxInitUnit = 5;
    private static int CurrentInitUnit = 0;
    
    public Guid Id { get; }
    public string Name { get; set; }
    public double Damage { get; private set; }
    public double Health { get; private set; }

    private Unit(string name, double damage, double health)
    {
        Id = Guid.NewGuid();
        Name = name;
        Damage = damage;
        Health = health;
        CurrentInitUnit++;
    }

    public static Unit? CreateUnit(string name, double damage, double health)
    {
        if (CurrentInitUnit == MaxInitUnit)
        {
            Console.WriteLine("Creating unit failed");
            Console.WriteLine("You have max unit capacity.");
            return null;
        }
        Console.WriteLine($"Creating unit {name}");
        return new Unit(name,damage,health);
    }
    
}