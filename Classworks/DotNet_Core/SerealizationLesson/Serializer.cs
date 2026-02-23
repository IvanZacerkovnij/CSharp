namespace SerealizationLesson;

abstract class Serializer
{
    public string path { get; private set; }

    public Serializer(string path)
    {
        this.path = path;
    }
    
    public abstract void Serialize(Person person);
    public abstract Person Deserialize();
}