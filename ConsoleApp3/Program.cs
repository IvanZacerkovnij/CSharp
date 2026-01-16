namespace ConsoleApp3;
class Car
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("audi", 2020);
        int i = 0;
        while (i < 2_000_000)
        {
            Car car2 = new Car("bmw", 2000);
            i++;
        }
        Console.WriteLine("байт в купі: {0}",
            GC.GetTotalMemory(false));
        Console.WriteLine(GC.GetGeneration(car));
    }
}