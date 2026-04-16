namespace Homework4_EF.Entities;

public class Curator
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;

    public Group? Group { get; set; }
}
