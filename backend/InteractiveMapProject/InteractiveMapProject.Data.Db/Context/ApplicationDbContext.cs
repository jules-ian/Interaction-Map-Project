using System.Reflection;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Context;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  //DbContext
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

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseMySql("server=127.0.0.1;uid=root;pwd=1234;database=test", ServerVersion.AutoDetect("server=127.0.0.1;uid=root;pwd=1234;database=test"),
            b => b.MigrationsAssembly("InteractiveMapProject.Data.Db"));
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
