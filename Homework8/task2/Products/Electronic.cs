namespace Homework8.task2.Products;

public class Electronic : Product
{
    public Electronic(string name,  double price) :  base(name, price) {}

    public override string ToString()
    {
        return $"{Name},  Price: {Price}, Date added {AddedAt}";
    }
}