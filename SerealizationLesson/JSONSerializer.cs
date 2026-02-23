using Newtonsoft.Json;

namespace SerealizationLesson;

class JSONSerializer : Serializer
{
    public JSONSerializer(string path) : base(path + ".json") {}

    public override void Serialize(Person person)
    {
        string json = JsonConvert.SerializeObject(person);
        File.WriteAllText(path, json);
    }

    public override Person Deserialize()
    {
        string json = File.ReadAllText(path);
        var data = JsonConvert.DeserializeObject<Person>(json);
        return data;
    }
}