namespace InterfaceLesson;
interface IDevice
{
    void TurnOn();
    void TurnOff();
    
    string ToString();
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
