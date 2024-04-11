using System.Reflection;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Context;

public class ApplicationDbContext : DbContext
{
    // Database tables
    public DbSet<Professional> Professionals { get; set; } = default!;
    public DbSet<PendingProfessional> PendingProfessionals { get; set; } = default!;
    public DbSet<Audience> Audiences { get; set; } = default!;
    public DbSet<PlaceOfIntervention> PlacesOfIntervention { get; set; } = default!;
    public DbSet<Mission> Missions { get; set; } = default!;
    public DbSet<ValidationStatus> ValidationStatuses { get; set; } = default!;

    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //<ApplicationDbContext> needed ?
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
