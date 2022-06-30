using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data.Models;
using System;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {


        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatistic> PlayersStatistics { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>().HasKey(x => new { x.GameId, x.PlayerId });

            modelBuilder.Entity<Team>()
                .HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.PrimaryKitTeams)
                .HasForeignKey(t => t.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>()
               .HasOne(t => t.SecondaryKitColor)
               .WithMany(c => c.SecondaryKitTeams)
               .HasForeignKey(t => t.SecondaryKitColorId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
             .HasOne(g => g.HomeTeam)
             .WithMany(t => t.HomeGames)
             .HasForeignKey(g => g.HomeTeamId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
             .HasOne(g => g.AwayTeam)
             .WithMany(t => t.AwayGames)
             .HasForeignKey(g => g.AwayTeamId)
             .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
    }
}
