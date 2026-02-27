namespace FluentApi.Entities;

public class Curator
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public List<Group> Groups = new();
}