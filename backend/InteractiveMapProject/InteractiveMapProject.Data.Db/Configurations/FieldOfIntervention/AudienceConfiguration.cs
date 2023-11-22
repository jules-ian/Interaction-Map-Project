using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class AudienceConfiguration : IEntityTypeConfiguration<Audience>
{

    public void Configure(EntityTypeBuilder<Audience> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Professionals)
            .WithOne(p => p.Audience);

        builder.HasData(
            new Audience(Id = Guid.NewGuid() , Name = "0-3 ans"),
            new Audience(Id = Guid.NewGuid(), Name = "3-6 ans"),
            new Audience(Id = Guid.NewGuid(), Name = "6-12 ans"),
            new Audience(Id = Guid.NewGuid(), Name = "12-18 ans"),
            new Audience(Id = Guid.NewGuid(), Name = "Parents"),
            new Audience(Id = Guid.NewGuid(), Name = "Professionnels")
            )
    }
}
