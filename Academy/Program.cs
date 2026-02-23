using Academy.Context;
using Academy.Entities;

namespace Academy;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AcademyDBContext())
        {
            context.Database.EnsureCreated();
            Console.WriteLine("CanConnect = " + context.Database.CanConnect());
            Console.WriteLine("Provider = " + context.Database.ProviderName);
            context.Students.Add(new Student(){ Name =  "John", Surname = "Doe"});
            context.SaveChanges();
        }
    }
}