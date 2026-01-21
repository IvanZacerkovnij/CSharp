namespace LinqLesson;

public class Developer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    public List<string> ProgramingLanguages { get; set; }

    public Developer(string name, int age, string country, List<string> programingLanguages)
    {
        Name = name;
        Age = age;
        Country = country;
        ProgramingLanguages = programingLanguages;
    }

    public void ShowLanguages()
    {
        foreach (var lang in ProgramingLanguages)
        {
            Console.WriteLine(lang);
        }
    }

    public override string ToString()
    {
        return $"{Name}, {Age}, {Country} ";
    }
}