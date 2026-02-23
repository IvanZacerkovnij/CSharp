namespace Homework10;

public class MemoryAllocator : IDisposable
{
    public int[] arr;

    public MemoryAllocator()
    {
        arr = new int[1000000];
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose called");
    }
    ~MemoryAllocator()
    {
        Console.WriteLine("Finalizer called");
    }
}