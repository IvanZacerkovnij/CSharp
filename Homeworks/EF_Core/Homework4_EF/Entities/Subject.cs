namespace Homework4_EF.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;

    public List<Grade> Grades { get; set; } = new();
}