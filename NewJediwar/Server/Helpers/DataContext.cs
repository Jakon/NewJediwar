using Microsoft.EntityFrameworkCore;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Server.Helpers;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DbSet<Player> Players { get; set; }

    public DbSet<GroundEnvironment> GroundEnvironments { get; set; }

    public DbSet<PlanetGround> PlanetGrounds { get; set; }

    public DbSet<Planet> Planets { get; set; }

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server database
        options.UseSqlite(Configuration.GetConnectionString("Default"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>()
            .HasIndex(p => p.Login).IsUnique();

        modelBuilder.Entity<Planet>()
            .HasMany(p => p.Cells)
            .WithOne(c => c.Planet)
            .HasForeignKey(c => c.PlanetId)
            .IsRequired();

        modelBuilder.Entity<PlanetGround>()
            .HasOne(pg => pg.GroundEnvironment)
            .WithOne()
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Ignore<Character>();

        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        AddTimestamps();
        return base.SaveChanges();
    }

    private void AddTimestamps()
    {
        var now = DateTime.UtcNow;

        var entities = ChangeTracker.Entries()
            .Where(x => x.State is EntityState.Added or EntityState.Modified);

        foreach (var entry in entities)
        {
            var createdAt = entry.Entity.GetType().GetProperty("CreatedAt");
            var updatedAt = entry.Entity.GetType().GetProperty("UpdatedAt");

            if (createdAt != null && entry.State == EntityState.Added)
                createdAt.SetValue(entry.Entity, now);

            if (updatedAt != null)
                updatedAt.SetValue(entry.Entity, now);
        }
    }
}
