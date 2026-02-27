namespace MigrationEF.Entity;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public int GroupId { get; set; }
    
    public Group Group { get; set; }
}