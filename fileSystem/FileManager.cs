using Newtonsoft.Json;

namespace fileSystem;

public class FileManager
{
    public string path { get; private set; }
    public List<People>? data;
    public FileManager(string path)
    {
        this.path = path;
        string json = File.ReadAllText(path);
        data = JsonConvert.DeserializeObject<List<People>>(json);
    }
    
    public void AddPersonToFile(People person)
    {
        data.Add(person);
        File.WriteAllText(path, JsonConvert.SerializeObject(data));
    }
    public void ShowAllPeople()
    {
        for (int i = 0; i < data.Count; i++)
        {
            Console.WriteLine($"id:{i} {data[i]}");
        }
    }

    public bool RemovePersoneToFile(int id)
    {
        if (id < 0 || id > data.Count)
        {
            return false;
        }
        else
        {
            data.RemoveAt(id);
            File.WriteAllText(path, JsonConvert.SerializeObject(data));
            return true;
        }
    }
}