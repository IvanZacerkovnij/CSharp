namespace Homework11;

public class Journal
{
    public string Name { get; }
    public string Publisher { get; }
    public DateTime RealeseDate { get; }
    public int CountPages { get; }

    public Journal(string name, string publisher, DateTime realeseDate, int countPages)
    {
        Name = name;
        Publisher = publisher;
        RealeseDate = realeseDate;
        CountPages = countPages;
    }

    public override string ToString()
    {
        return $"Journal name: {Name}, publisher: {Publisher}, realese date: {RealeseDate}, count: {CountPages}";
    }
}