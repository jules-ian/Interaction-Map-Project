using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class ProfessionalPlaceOfInterventionConfiguration : IEntityTypeConfiguration<ProfessionalPlaceOfIntervention>
{
    public void Configure(EntityTypeBuilder<ProfessionalPlaceOfIntervention> builder)
    {
        builder.ToTable("ProfessionalsPlacesOfIntervention");

        builder
            .HasKey(pa => new { ProfessionalId = pa.ProfessionalId, MissionId = pa.PlaceOfInterventionId });

        builder
            .HasOne(pb => pb.Professional)
            .WithMany(p => p.PlacesOfIntervention)
            .HasForeignKey("ProfessionalId");

        builder
            .HasOne(pb => pb.PlaceOfIntervention)
            .WithMany(b => b.Professionals)
            .HasForeignKey("PlaceOfInterventionId");
    }
}
