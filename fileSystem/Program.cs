using Newtonsoft.Json;
using System.Collections.Generic;

namespace fileSystem;

class Program
{
    private static string path = Path.Combine(Directory.GetCurrentDirectory() ,"../../../test/person.json");
    
    static void Main(string[] args)
    {
        List<People> personeList = new List<People>();
        for (int i = 0; i < 5; i++)
        {
            People people = new People("Ivan", (byte)i);
            personeList.Add(people);
        }
        
        string json = JsonConvert.SerializeObject(personeList);
        File.WriteAllText(path, json);
        
        FileManager fileManager = new FileManager(path);
        fileManager.AddPersonToFile(new People());
        fileManager.ShowAllPeople();
        Console.WriteLine();
        fileManager.RemovePersoneToFile(0);
        fileManager.RemovePersoneToFile(2);
        fileManager.ShowAllPeople();
    }
}