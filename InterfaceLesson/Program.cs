namespace InterfaceLesson;

class Scanner : Device ,IDevice, IScanner
{
    public Scanner(string name): base(name){}
    public void TurnOn()
    {
        Console.WriteLine("Scanner turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Scanner turned off");
    }

    public void Scan()
    {
        Console.WriteLine("Scanner scanned on");
    }

    public override string ToString()
    {
        return $"Name: {this.name}, DeviceType: {this.GetType().Name}";
    }
}
class Printer : Device, IDevice, IPrinter
{
    public Printer(string name): base(name){}
    public void TurnOn()
    {
        Console.WriteLine("Printer turned on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Printer turned off");
    }

    public void Print()
    {
        Console.WriteLine("Printer printed");
    }

    public override string ToString()
    {
        return $"Name: {this.name}, DeviceType: {this.GetType().Name}";
    }
}
class Copier : Device, IDevice, ICopier
{
    public Copier(string name): base(name){}
    public void TurnOn()
    {
        Console.WriteLine("Copier turned on");
    }
    public void TurnOff(){
        Console.WriteLine("Copier turned off");
    }
    public void Copy()
    {
        Console.WriteLine("Copier copied on");
    }

    public override string ToString()
    {
        return $"Name: {this.name}, DeviceType: {this.GetType().Name}";
    }
}

class MultiDevice : Device, IDevice, IScanner, ICopier, IPrinter
{
    public MultiDevice(string name): base(name){}
    public void TurnOn()
    {
        Console.WriteLine("Multi device turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("Multi device turned off");
    }
    public void Scan(){
        Console.WriteLine("Multi device scanned on");
    }
    public void Copy(){
        Console.WriteLine("Multi device copied on");
    }
    public void Print()
    {
        Console.WriteLine("Multi device printed");
    }

    public override string ToString()
    {
        return $"Name: {this.name}, DeviceType: {this.GetType().Name}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Office office = new Office();
        office.AddDevice(new Scanner("Cannon"));
        office.AddDevice(new Printer("HP"));
        office.AddDevice(new Copier("Xerox"));
        office.AddDevice(new MultiDevice("Epson"));
        office.TurnOnAllDevices();
        office.StartPrint();
        office.StartScan();
        office.StartCopy();
        office.TurnOffAllDevices();
    }
}