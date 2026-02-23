namespace Homework7;

public class Item
{
    public string Name { get; private set; }
    public double Size { get; private set; }

    public Item(string name, double size)
    {
        Name = name;
        Size = size;
    }

    public void ChangeSize(double newSize)
    {
        Size = newSize;
    }
    public override string ToString()
    {
        return $"Item: {Name}, Size: {Size}";
    }
}