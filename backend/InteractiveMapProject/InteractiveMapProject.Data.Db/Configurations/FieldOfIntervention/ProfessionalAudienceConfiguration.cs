using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class ProfessionalAudienceConfiguration : IEntityTypeConfiguration<ProfessionalAudience>
{
    public void Configure(EntityTypeBuilder<ProfessionalAudience> builder)
    {
        builder.ToTable("ProfessionalsAudiences");

        builder
            .HasKey(pa => new { ProfessionalId = pa.ProfessionalId, AudienceId = pa.AudienceId });

        builder
            .HasOne(pb => pb.Professional)
            .WithMany(p => p.Audiences)
            .HasForeignKey("ProfessionalId");

        builder
            .HasOne(pb => pb.Audience)
            .WithMany(b => b.Professionals)
            .HasForeignKey("AudienceId");
    }
}
