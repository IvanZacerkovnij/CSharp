namespace InterfaceLesson;

abstract class OfficeDevice
{
    public List<IDevice> devices = new List<IDevice>();

    public void AddDevice(IDevice device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(IDevice device)
    {
        if (devices.Contains(device))
        {
            devices.Remove(device);
        }
        else
        {
            Console.WriteLine("There is no active device with that name");
        }
    }

    public void TurnOnAllDevices()
    {
        Console.WriteLine("Turning on all devices");
    }

    public void TurnOffAllDevices()
    {
        Console.WriteLine("Turning off all devices");
    }
}