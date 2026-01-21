namespace LinqLesson;

class Program
{
    static void task1(List<Developer> developers)
    {
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

    static void task2(List<Developer> developers)
    {
        Console.WriteLine();
        var age = from dev in developers
            orderby dev.Age descending
            select dev;
        foreach (var dev in age)
        {
            Console.WriteLine(dev);
        }

        Console.WriteLine();
        var age2 = developers.OrderByDescending(dev => dev.Age);
        foreach (var dev in age2)
        {
            Console.WriteLine(dev);
        }

        Console.WriteLine();
        var devKnowsCSharp = from dev in developers
            where dev.ProgramingLanguages.Contains("C#")
            select dev;
        Console.WriteLine($"{devKnowsCSharp.Count()} developers know C#");

        var devKnowsCsharp2 = developers.Where(dev => dev.ProgramingLanguages.Contains("C#")).Count();
        Console.WriteLine($"{devKnowsCsharp2} developers know C#");
        
        Console.WriteLine();
        var salary = developers.Average(dev => dev.Salary);
        Console.WriteLine($"average salary: {salary}");
    }
    
    static void Main(string[] args)
    {
        List<Developer> developers = new()
        {
            new Developer("Ivan", 20, "Ukraine", 500, new List<string>() { "Java", "C#", "C++" }),
            new Developer("Oleg", 28, "Germany",700, new List<string>() { "Java", "C++" }),
            new Developer("Igor", 21, "Ukraine", 800,new List<string>() { "Java" }),
            new Developer("David", 18, "France",300 ,new List<string>() { "Python" })
        };
        // task1(developers);
        task2(developers);
            
    }
}