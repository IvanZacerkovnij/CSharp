namespace LinqLesson;

class Program
{
    static void Main(string[] args)
    {
        List<Developer> developers = new()
        {
            new Developer("Ivan", 20, "Ukraine", new List<string>() { "Java","C#", "C++" }),
            new Developer("Oleg", 28, "Germany", new List<string>() { "Java","C++"}),
            new Developer("Igor", 21, "Ukraine", new List<string>() { "Java" }),
            new Developer("David", 18, "France", new List<string>() { "Python" })
        };
        
        var requiredDevs = from dev in developers
                           where dev.Country == "Ukraine" || dev.Country == "France"
                           select dev;
        foreach (var dev in requiredDevs)
        {
            Console.WriteLine(dev);
        }
        Console.WriteLine();
        var languages = from dev in developers
                        where dev.ProgramingLanguages.Contains("C#")
                        where dev.ProgramingLanguages.Contains("Java")
                        select dev;
        foreach (var dev in languages)
        {
            Console.WriteLine(dev);
            dev.ShowLanguages();
            Console.WriteLine();
        }
        Console.WriteLine();
        var languages2 = from dev in developers
                         from lang in dev.ProgramingLanguages
                         where dev.ProgramingLanguages.All(l => l != "C++")
                         where dev.Age > 20
                         select dev;
        foreach (var dev in languages2)
        {
            Console.WriteLine(dev);
            dev.ShowLanguages();
        }
        
        Console.WriteLine();
        Console.WriteLine("Second method:");
        var requiredDevs2 = developers.Where(dev => dev.Country == "Ukraine" 
                                                    || dev.Country == "France");
        foreach (var dev in requiredDevs2)
        {
            Console.WriteLine(dev);
        }
        Console.WriteLine();
        var languages3 = developers.Where(dev => dev.ProgramingLanguages.Contains("C#") 
                                                                            && dev.ProgramingLanguages.Contains("Java"));
        foreach (var dev in languages3)
        {
            Console.WriteLine(dev);
            dev.ShowLanguages();
        }
        Console.WriteLine();
        var languages4 = developers.Where(dev => !(dev.ProgramingLanguages.Contains("C++"))
                                                                            && dev.Age > 20);
        foreach (var dev in languages4)
        {
            Console.WriteLine(dev);
            dev.ShowLanguages();
        }
    }
}