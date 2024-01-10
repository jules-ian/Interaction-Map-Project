using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class ProfessionalMissionConfiguration : IEntityTypeConfiguration<ProfessionalMission>
{
    public void Configure(EntityTypeBuilder<ProfessionalMission> builder)
    {
        builder.ToTable("ProfessionalsMissions");

        builder
            .HasKey(pa => new { ProfessionalId = pa.ProfessionalId, MissionId = pa.MissionId });

        builder
            .HasOne(pb => pb.Professional)
            .WithMany(p => p.Missions)
            .HasForeignKey("ProfessionalId");

        builder
            .HasOne(pb => pb.Mission)
            .WithMany(b => b.Professionals)
            .HasForeignKey("MissionId");
    }
}
