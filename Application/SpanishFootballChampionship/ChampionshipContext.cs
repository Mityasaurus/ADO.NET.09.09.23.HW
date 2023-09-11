using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Application
{
    public class ChampionshipContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ToString());
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
            new Team() { ID = 1, TeamName = "Real Madrid", TeamCity = "Madrid", Wins = 21, Losses = 6, Draws = 11 },
            new Team() { ID = 2, TeamName = "FC Barcelona", TeamCity = "Barcelona", Wins = 26, Losses = 3, Draws = 9 },
            new Team() { ID = 3, TeamName = "Atletico Madrid", TeamCity = "Madrid", Wins = 22, Losses = 10, Draws = 6 },
            new Team() { ID = 4, TeamName = "Valencia CF", TeamCity = "Valencia", Wins = 15, Losses = 16, Draws = 7 },
            new Team() { ID = 5, TeamName = "Sevilla FC", TeamCity = "Seville", Wins = 17, Losses = 13, Draws = 8 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}