using System.Reflection;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Context;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>  //DbContext
{
    // Database tablesa
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
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PendingProfessional>()
        .HasOne(pp => pp.ValidationStatus)
        .WithMany()
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasKey(ul => new { ul.LoginProvider, ul.ProviderKey });
        });
        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.HasKey(ur => new { ur.UserId, ur.RoleId });
        });
        modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Name });
        });
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
