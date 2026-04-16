namespace Homework4_EF.Entities;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Student> Students { get; set; } = new();
    
    public Curator? Curator { get; set; }
    public int CuratorId { get; set; }
}