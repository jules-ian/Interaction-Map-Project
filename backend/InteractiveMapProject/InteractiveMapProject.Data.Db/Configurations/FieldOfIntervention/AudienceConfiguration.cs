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
    }
}
