using Microsoft.EntityFrameworkCore;
using SpainChampionship.Entities;

namespace SpainChampionship.Context;

public class PlayersDBContext : DbContext
{
    public DbSet<Player> Players { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            $"Server=localhost,1433;Database=SpainChampionship;User Id=SA;Password=Skylex717820732!;Encrypt=False;");
    }
}