namespace Homework8.task2.Products;

public abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime AddedAt { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
        AddedAt = DateTime.Now;
    }
}