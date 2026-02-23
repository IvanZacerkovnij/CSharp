namespace SpainChampionship.Entities;

public class Player
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public int Number { get; set; }
    public string Role { get; set; } = string.Empty;
}