using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CompanyForum.Infrastructure;

public class CompanyForumDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(configuration.GetConnectionString("Database"));
        
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyForumDbContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}