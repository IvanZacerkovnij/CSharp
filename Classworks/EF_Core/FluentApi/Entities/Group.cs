namespace FluentApi.Entities;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CuratorId { get; set; }
    public Curator Curator { get; set; } = null!;

    public List<Student> Students { get; set; } = new();
}