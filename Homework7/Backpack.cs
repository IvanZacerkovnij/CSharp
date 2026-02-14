namespace Homework7;

public class Backpack
{
    public string Color { get; private set; }
    public string Brand { get; private set; }
    public string Cloth { get; private set; }
    public double Weight { get; private set; }
    public double Volume { get; private set; }

    private List<Item> _items = new List<Item>();

    public double CurrentVolume => _items.Sum(i => i.Size);
    
    public event Action<Item>? AddItem;
    public event Action<Item>? RemoveItem;
    public event Action<Item>? ChangeItem;

    public Backpack(string color, string brand, string cloth, double weight, double volume)
    {
        Color = color;
        Brand = brand;
        Cloth = cloth;
        Weight = weight;
        Volume = volume;
    }

    public void UpdateColor(string color)
    {
        Color = color;
    }
    public void UpdateBrand(string brand)
    {
        Brand = brand;
    }

    public void UpdateCloth(string cloth)
    {
        Cloth = cloth;
    }

    public void UpdateWeight(double newWeight)
    {
        Weight = newWeight;
    }
    public void UpdateVolume(double newVolume)
    {
        Volume = newVolume;
    }

    public void Add(Item item)
    {
        if (item.Size + CurrentVolume > Volume)
        {
            throw new Exception("Backpack is full!");
        }
        _items.Add(item);
        AddItem?.Invoke(item);
    }

    public void Remove(Item item)
    {
        if (_items.Remove(item))
        {
            RemoveItem?.Invoke(item);
        }
    }

    public void Change(Item item , double newVolume)
    {
        if (_items.Contains(item))
        {
            if (CurrentVolume - item.Size + newVolume > Volume)
            {
                throw new Exception("Backpack is full!");
            }
            item.ChangeSize(newVolume);
            ChangeItem?.Invoke(item);
        }
        throw new Exception("Invalid item!");
    }
}