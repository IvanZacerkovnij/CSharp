using System;
using System.Diagnostics;

namespace garbageCollector;

class MemoryAllocator 
{
    private int[] arr;

    public MemoryAllocator()
    {
        arr = new int[10];
    }
    
}

class Program
{
    static void Main(string[] args)
    {

        List<MemoryAllocator> test = new List<MemoryAllocator>();
        for (uint i = 0; i < 1000; i++)
        {
            test.Add(new MemoryAllocator());
        }
        Console.WriteLine("Використано пам'яті: {0}",GC.GetTotalMemory(false));
        Console.WriteLine("Покоління першого об'єкту: {0}", GC.GetGeneration(test[0]));
        test.RemoveRange(100,500);
        for (uint i = 0; i < 100000; i++)
        {
            test.Add(new MemoryAllocator());
        }
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        GC.Collect();
        stopwatch.Stop();
        Console.WriteLine("Затрачений час збиральником сміття: {0} мс",stopwatch.ElapsedMilliseconds);
        
        Console.WriteLine("Покоління першого об'єкту: {0}", GC.GetGeneration(test[0]));

    }
}