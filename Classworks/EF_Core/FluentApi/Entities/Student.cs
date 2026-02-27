namespace FluentApi.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; } = null!;

    public List<GradeSubjectStudent> Subjects { get; set; } = new();

}