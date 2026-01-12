namespace shopProject;

public class Product: IComparable<Product>
{
    private static int _id = 0;
    public int Id { get; }
    public string? Name { get; set; }
    public double Price { get; set; }
    
    public Product(string name, double price)
    {
        Id = _id++;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Id}: {Name}, {Price}";
    }

    public int CompareTo(Product? other)
    {
        if(other == null) return 1;
        return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }
}