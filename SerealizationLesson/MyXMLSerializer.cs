using System;
using System.IO;
using System.Xml.Serialization;

namespace SerealizationLesson;

class MyXMLSerializer : Serializer
{
    public MyXMLSerializer(string path) :  base(path + ".xml") {}

    public override void Serialize(Person person)
    {
        var serializer = new XmlSerializer(typeof(Person));
        using (var writer = new StreamWriter(path))
        {
            serializer.Serialize(writer, person);
        }
    }

    public override Person Deserialize()
    {
        var deserializer = new XmlSerializer(typeof(Person));
        using (var reader = new StreamReader(path))
        {
            Person person = (Person)deserializer.Deserialize(reader);
            return person;
        }
    }
}