using SpainChampionship.Context;
using SpainChampionship.Entities;

namespace SpainChampionship;

class Program
{
    static void InputPlayer(out string playerName, out string playerCountry, out int playerNumber, out string playerRole)
    {
        Console.Write("Enter the full name of the player: ");
        playerName = Console.ReadLine();
        Console.Write("Enter the country of the player: ");
        playerCountry = Console.ReadLine();
        Console.Write("Enter the number of the player: ");
        playerNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the role of the player: ");
        playerRole = Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        using (var db = new PlayersDBContext())
        {
            db.Database.EnsureCreated();
            InputPlayer(
                out string playerName,
                out string playerCountry,
                out int playerNumber,
                out string playerRole);
            db.Players.Add(new Player(){
                FullName = playerName,
                Country = playerCountry,
                Number = playerNumber,
                Role = playerRole});
            db.SaveChanges();
        }
    }
}