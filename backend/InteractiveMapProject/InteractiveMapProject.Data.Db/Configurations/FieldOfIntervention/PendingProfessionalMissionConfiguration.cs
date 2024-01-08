using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class PendingProfessionalMissionConfiguration : IEntityTypeConfiguration<PendingProfessionalMission>
{
    public void Configure(EntityTypeBuilder<PendingProfessionalMission> builder)
    {
        builder.ToTable("PendingProfessionalsMissions");

        builder
            .HasKey(pa => new { PendingProfessionalId = pa.PendingProfessionalId, MissionId = pa.MissionId });

        builder
            .HasOne(pb => pb.PendingProfessional)
            .WithMany(p => p.Missions)
            .HasForeignKey("PendingProfessionalId");

        builder
            .HasOne(pb => pb.Mission)
            .WithMany(b => b.PendingProfessionals)
            .HasForeignKey("MissionId");
    }
}
