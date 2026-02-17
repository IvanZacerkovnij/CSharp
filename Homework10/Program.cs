using System;
using System.Diagnostics;

namespace Homework10;

class Program
{
    static void Main(string[] args)
    {
        var arr = new List<MemoryAllocator>();
        arr.Add(new MemoryAllocator());
        Console.WriteLine($"Покоління першого об'єкта: {GC.GetGeneration(arr[0])}");
        Console.WriteLine("Використано пам'яті до збирача сміття: {0}",GC.GetTotalMemory(false));
        for(int i = 0; i < 100; i++)
        {
            var tmp = new byte[256];
            tmp[0] = 1;
        }
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        stopwatch.Stop();
        Console.WriteLine("Затрачений час збиральником сміття: {0} мс",stopwatch.ElapsedMilliseconds);
        Console.WriteLine($"Покоління першого об'єкта: {GC.GetGeneration(arr[0])}");
        Console.WriteLine("Використано пам'яті після збирача сміття: {0}",GC.GetTotalMemory(false));
    }
}