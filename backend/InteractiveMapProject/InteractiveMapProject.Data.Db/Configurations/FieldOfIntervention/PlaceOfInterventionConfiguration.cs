using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class PlaceOfInterventionConfiguration : IEntityTypeConfiguration<PlaceOfIntervention>
{

    public void Configure(EntityTypeBuilder<PlaceOfIntervention> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Professionals)
            .WithOne(p => p.PlaceOfIntervention);

        builder.HasData(
            new PlaceOfIntervention(Id = Guid.NewGuid(), Name = "Domicile"),
            new PlaceOfIntervention(Id = Guid.NewGuid(), Name = "EAJE"),
            new PlaceOfIntervention(Id = Guid.NewGuid(), Name = "École"),
            new PlaceOfIntervention(Id = Guid.NewGuid(), Name = "Cabinet")
            )
    }
}
