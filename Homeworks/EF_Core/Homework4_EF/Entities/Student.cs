namespace Homework4_EF.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public DateTime BirthDate { get; set; } = DateTime.Now;
    
    public Group? Group { get; set; }
    public int GroupId { get; set; }
    public Curator? Curator { get; set; }

    public List<Grade>? Grades { get; set; } = new();
}