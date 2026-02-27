namespace FluentApi.Entities;

public class GradeSubjectStudent
{
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    
    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
    
    public int Value { get; set; }
}