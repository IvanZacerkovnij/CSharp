namespace InterfaceLesson;

interface IDevice
{
    void TurnOn();
    void TurnOff();
}

interface IScanner
{
    void Scan();
}

interface IPrinter
{
    void Print();
}

interface ICopier
{
    void Copy();
}

class Program
{

    class Scanner : IDevice, IScanner
    {
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
    }
    class Printer : IDevice, IPrinter
    {
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
    }
    class Copier : IDevice, ICopier
    {
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
    }

    class MultiDevice : IDevice, IScanner, ICopier, IPrinter
    {
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
    }
    
    static void Main(string[] args)
    {
        
    }
}