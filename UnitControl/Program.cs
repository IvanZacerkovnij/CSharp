namespace UnitControl;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 6; i++)
        {
            Unit? creature = Unit.CreateUnit("ork", 30, 20);
        }
    }
}