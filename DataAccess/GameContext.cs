using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DataAccess.Entities;
using DataAccess.Seeding;
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace DataAccess
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GameContext>
    {
        public GameContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GameContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=sim;Username=postgres;Password=pass1234;");

            return new GameContext(optionsBuilder.Options);
        }
    }

    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options): base(options)
        {}
        public DbSet<Card> Cards { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new RuleConfiguration());
            modelBuilder.ApplyConfiguration(new AbilityConfiguration());
            // Call the seeding method
            modelBuilder.SeedAbilities();
        }        
    }
}
