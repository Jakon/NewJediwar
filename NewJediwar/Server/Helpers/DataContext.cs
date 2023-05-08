using Microsoft.EntityFrameworkCore;
using NewJediwar.Shared.Entities;

namespace NewJediwar.Server.Helpers;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server database
        options.UseSqlite(Configuration.GetConnectionString("Default"));
    }

    public DbSet<Player> Players { get; set; }
}
