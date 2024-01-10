using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class PendingProfessionalAudienceConfiguration : IEntityTypeConfiguration<PendingProfessionalAudience>
{
    public void Configure(EntityTypeBuilder<PendingProfessionalAudience> builder)
    {
        builder.ToTable("PendingProfessionalAudiences");

        builder
            .HasKey(pa => new { PendingProfessionalId = pa.PendingProfessionalId, AudienceId = pa.AudienceId });

        builder
            .HasOne(pb => pb.PendingProfessional)
            .WithMany(p => p.Audiences)
            .HasForeignKey("PendingProfessionalId");

        builder
            .HasOne(pb => pb.Audience)
            .WithMany(b => b.PendingProfessionals)
            .HasForeignKey("AudienceId");
    }
}
