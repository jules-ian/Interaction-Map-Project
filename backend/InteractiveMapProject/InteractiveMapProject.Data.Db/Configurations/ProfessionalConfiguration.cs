using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Data.Db.Configurations;

public class ProfessionalConfiguration : IEntityTypeConfiguration<Professional>
{

    public void Configure(EntityTypeBuilder<Professional> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .OwnsOne(p => p.Address);

        builder
            .OwnsOne(p => p.FieldOfIntervention);

        builder
            .OwnsOne(p => p.Geolocation);
    }
}
