namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Backpack backpack = new Backpack("White", "Nike", "Cotton", 0.5, 20);
        backpack.AddItem += delegate(Item item)
        {
            Console.WriteLine($"Item: {item.Name} added to Backpack");
        };
        backpack.RemoveItem += delegate(Item item)
        {
            Console.WriteLine($"Item: {item.Name} removed from Backpack");
        };
        backpack.ChangeItem += delegate(Item item)
        {
            Console.WriteLine($"Item: {item.Name} changed size");
        };

        try
        {
            backpack.Add(new Item("Laptop", 15));
            backpack.Add(new Item("Phone", 7));
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}