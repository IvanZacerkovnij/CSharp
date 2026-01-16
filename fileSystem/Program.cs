using Newtonsoft.Json;
using System.Collections.Generic;

namespace fileSystem;

class Program
{
    static void Main(string[] args)
    {
        List<People> personeList = new List<People>();
        for (int i = 0; i < 5; i++)
        {
            People people = new People("Ivan", (byte)i);
            personeList.Add(people);
        }
        
        string json = JsonConvert.SerializeObject(personeList);
        File.WriteAllText("person.json", json);
    }
}