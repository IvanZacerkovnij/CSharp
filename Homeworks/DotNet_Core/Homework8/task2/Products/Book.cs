namespace Homework8.task2.Products;

public class Book : Product
{
    public string Author { get; set; }
    
    public Book(string name, double price, string author) : base(name, price)
    {
        Author = author;
    }
    public override string ToString()
    {
        return $"{Name}, Author: {Author}, Price: {Price}, Date added: {AddedAt}";
    }
}