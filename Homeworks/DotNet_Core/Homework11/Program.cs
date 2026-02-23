namespace Homework11;

class Program
{
    static void InputData(out string name, out string  publisher , out DateTime releaseDate, out int countPages)
    {
        Console.WriteLine("Enter a name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter a publisher:");
        publisher = Console.ReadLine();
        Console.WriteLine("Enter a releaseDate:");
        releaseDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter a countPages:");
        countPages = int.Parse(Console.ReadLine());
    }
    
    static void Main(string[] args)
    {
        
        InputData(out string name, out string publisher, out DateTime releaseDate, out int countPages);
        
        Journal journal = new Journal(name, publisher, releaseDate, countPages);
        Console.WriteLine(journal);
        Serializer.Save(journal);
        Journal? deserializedObj = Serializer.Load();
        Console.WriteLine(deserializedObj);
    }
}