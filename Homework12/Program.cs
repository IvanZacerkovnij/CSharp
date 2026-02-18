namespace Homework12;

class Program
{
    static void Main(string[] args)
    {
        List<Phone> phones = new();

        for (int i = 0; i < 100; i++)
        {
            phones.Add(new Phone("Iphone", 
                Publishers.Apple,
                19.99 + i * 10,
                new DateTime(2008 + i, 1, 1)));
        }
        Console.WriteLine("Кількість телефонів: {0}",phones.Count);
        Console.WriteLine("Кількість телефонів ціна якаких більше 100: {0}",phones.Count(p => p.Price > 100));
        Console.WriteLine("Кількість телефонів ціна якаких знаходиться в діапа зоні 100-700: {0}",
            phones.Count(p => p.Price > 100 && p.Price < 700));
        Console.WriteLine("Кількість телефонів виробника 'Apple': {0}",
            phones.Count(p => p.Publisher == Publishers.Apple));
        Console.WriteLine("Телефон з мінімальною ціною: {0}",
            phones.Min(p => p.Price));
        Console.WriteLine("Телефон з максимальною ціною: {0}",
            phones.Max(p => p.Price));
        Console.Write("Найстаріший телефон: ");
        Console.WriteLine(phones.OrderBy(p => p.RealeseDate).First());
        Console.Write("Найновіший телефон: ");
        Console.WriteLine(phones.OrderBy(p => p.RealeseDate).Last());
        Console.WriteLine("Середня ціна всіх телефонів: {0}", phones.Average(p => p.Price));
    }
}