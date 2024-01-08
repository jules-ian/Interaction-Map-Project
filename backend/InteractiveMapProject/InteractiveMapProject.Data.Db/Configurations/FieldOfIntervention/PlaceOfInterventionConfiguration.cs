using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class PlaceOfInterventionConfiguration : IEntityTypeConfiguration<PlaceOfIntervention>
{
    public void Configure(EntityTypeBuilder<PlaceOfIntervention> builder)
    {
        builder.ToTable("PlacesOfIntervention");

        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Professionals)
            .WithOne(p => p.PlaceOfIntervention);

        builder
            .HasMany(p => p.PendingProfessionals)
            .WithOne(p => p.PlaceOfIntervention);

        builder.HasData(
            new PlaceOfIntervention(Guid.NewGuid(), "Domicile"),
            new PlaceOfIntervention(Guid.NewGuid(), "EAJE"),
            new PlaceOfIntervention(Guid.NewGuid(), "École"),
            new PlaceOfIntervention(Guid.NewGuid(), "Structure individuelle"),
            new PlaceOfIntervention(Guid.NewGuid(), "Structure de soins"),
            new PlaceOfIntervention(Guid.NewGuid(), "Institution"),
            new PlaceOfIntervention(Guid.NewGuid(), "Structure d’orientation et d’information"),
            new PlaceOfIntervention(Guid.NewGuid(), "Tiers lieu")
        );
    }
}
