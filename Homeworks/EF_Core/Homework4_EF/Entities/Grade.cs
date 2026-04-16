namespace Homework4_EF.Entities;

public class Grade
{
    public int Id { get; set; }
    public int Value { get; set; }
    public DateTime DateAssigned { get; set; } = DateTime.Now;
    
    public Student? Student { get; set; }
    public int StudentId { get; set; }
    
    public Subject? Subject { get; set; }
    public int SubjectId { get; set; }
}