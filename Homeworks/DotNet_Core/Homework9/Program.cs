using Homework9.task1;
using Homework9.task2;

namespace Homework9;

class Program
{
    public static void task1()
    {
        //task1
        using var play = new Play("Romeo & Julieta", "William Shekspier", "romantic", new DateTime(1700,1,1));
        Console.WriteLine(play);
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    public static void task2()
    {
        //task2
        using var magazine = new Magazine("Kopiechka", "Golovna 102", MagazineType.Economic);
        Console.WriteLine(magazine);
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
    
    
    static void Main(string[] args)
    {
        task1();
        task2();
    }
}