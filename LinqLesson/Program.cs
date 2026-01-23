namespace LinqLesson;

class Program
{
    static void linqGroup(List<Developer> developers)
    {
        var developerGroup = from dev in developers
            group dev by dev.Position;
        foreach (var dev in developerGroup)
        {
            Console.WriteLine(dev.Key + ":");
            foreach (var groupDev in dev)
            {
                Console.WriteLine(groupDev.Name);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Linq Extension group");
        var developerGroup2 = developers.GroupBy(dev => dev.Name);
        foreach (var dev in developerGroup2)
        {
            Console.WriteLine(dev.Key + ":");
            foreach (var groupDev in dev)
            {
                Console.WriteLine(groupDev.Name);
            }
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {
        List<Developer> developers = new()
        {
            new Developer("Ivan", 500, "Junior"),
            new Developer("Oleg" , 1500 , "Senior"),
            new Developer("Igor", 800 , "Middle"),
            new Developer("David",300 , "Junior")
        };
        linqGroup(developers);
            
    }
}