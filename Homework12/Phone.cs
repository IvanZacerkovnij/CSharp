namespace Homework12;

public class Phone
{
    public string Name { get;}
    public Publishers Publisher { get;}
    public double Price { get;}
    public DateTime RealeseDate { get;}

    public Phone(string name, Publishers publisher, double price, DateTime realeseDate)
    {
        Name = name;
        Publisher = publisher;
        Price = price;
        RealeseDate = realeseDate;
    }

    public override string ToString()
    {
        return $"Phone name: {Name}, publisher: {Publisher}, price: {Price}, realeseDate: {RealeseDate}";
    }
}