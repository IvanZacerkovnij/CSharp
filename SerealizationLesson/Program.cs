using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace SerealizationLesson;

class Program
{
    private static string path = Path.Combine(Directory.GetCurrentDirectory() ,"../../../test/person");
    
    static void Main(string[] args)
    {
        Person person = new Person("Ivan",20);

        SerializeManager serializeManager = new SerializeManager(path);
        serializeManager.Serialize(person);
        Person person2 = serializeManager.Deserialize();
        Console.WriteLine(person2);
    }
}