using Newtonsoft.Json;

namespace Homework11;

public static class Serializer
{
    private readonly static string _path = "../../../SavedFile.json";
    
    public static void Save(Journal journal)
    {
        string json = JsonConvert.SerializeObject(journal);
        File.WriteAllText(_path, json);
    }

    public static Journal? Load()
    {
        var deserialized = JsonConvert.DeserializeObject<Journal>(File.ReadAllText(_path));
        return deserialized;
    }
}