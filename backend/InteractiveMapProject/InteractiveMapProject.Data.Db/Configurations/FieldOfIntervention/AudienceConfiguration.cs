using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class AudienceConfiguration : IEntityTypeConfiguration<Audience>
{

    public void Configure(EntityTypeBuilder<Audience> builder)
    {
        builder.ToTable("Audiences");

        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Professionals)
            .WithOne(p => p.Audience);

        builder.HasData(
            new Audience(Guid.NewGuid(), "0-3 ans"),
            new Audience(Guid.NewGuid(), "3-6 ans"),
            new Audience(Guid.NewGuid(), "6-12 ans"),
            new Audience(Guid.NewGuid(), "12-18 ans"),
            new Audience(Guid.NewGuid(), "Parents"),
            new Audience(Guid.NewGuid(), "Professionnels")
            );
    }
}
