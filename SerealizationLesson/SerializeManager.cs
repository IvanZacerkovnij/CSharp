namespace SerealizationLesson;

public class SerializeManager
{
    private Serializer serializer;
    public string _path { get; private set; }

    public SerializeManager(string path)
    {
        _path = path;
        ChooseTypeSerializer();
    }

    public void ChooseTypeSerializer()
    {
        Console.WriteLine("Choose type serializer to serialize");
        Console.WriteLine("1.JSON file");
        Console.WriteLine("2.XML file");
        while (true)
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    serializer = new JSONSerializer(_path);
                    break;
                }
                case 2:
                {
                    serializer = new MyXMLSerializer(_path);
                    break;
                }
                default:
                    Console.WriteLine("Invalid choice, please try again");
                    break;
            }

            if (serializer != null)
            {
                break;
            }
        }
    }

    public void Serialize(Person person)
    {
        serializer.Serialize(person);
    }
    public Person Deserialize()
    {
        return serializer.Deserialize();
    }
}