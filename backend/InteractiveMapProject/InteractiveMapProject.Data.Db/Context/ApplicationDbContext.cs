using System.Reflection;
using InteractiveMapProject.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Professional> Professionals { get; set; } = default!;

    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly())
	}
}
