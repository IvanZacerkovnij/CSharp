namespace InterfaceLesson;

class Office : OfficeDevice
{
    public void StartPrint()
    {
        foreach (var device in devices)
        {
            if (device is IPrinter printeble)
            {
                printeble.Print();
                return;
            }
        }
        Console.WriteLine("There is no print available.");
    }
    public void StartScan()
    {
        foreach (var device in devices)
        {
            if (device is IScanner scanner)
            {
                scanner.Scan();
                return;
            }
        }
        Console.WriteLine("There is no scanner available.");
    }
    public void StartCopy()
    {
        foreach (var device in devices)
        {
            if(device is ICopier copier)
            {
                copier.Copy();
                return;
            }
        }
        Console.WriteLine("There is no copy available.");
    }

    public void PrintAllDevices()
    {
        foreach (var device in devices)
        {
            Console.WriteLine(device);
        }
    }
}