using InteractiveMapProject.Contracts.Entities.FieldOfIntervention;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMapProject.Data.Db.Configurations.FieldOfIntervention;

public class MissionConfiguration : IEntityTypeConfiguration<Mission>
{

    public void Configure(EntityTypeBuilder<Mission> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Professionals)
            .WithOne(p => p.Mission);

        builder.HasData(
            new Mission(Id = Guid.NewGuid(), Name = "Accueil de loisirs"),
            new Mission(Id = Guid.NewGuid(), Name = "Petite enfance"),
            new Mission(Id = Guid.NewGuid(), Name = "Répit"),
            new Mission(Id = Guid.NewGuid(), Name = "Accueil occasionnel"),
            new Mission(Id = Guid.NewGuid(), Name = "Scolarité"),
            new Mission(Id = Guid.NewGuid(), Name = "Référent santé accueil inclusif (RSAI)"),
            new Mission(Id = Guid.NewGuid(), Name = "Accueil de jour"),
            new Mission(Id = Guid.NewGuid(), Name = "Accueil de nuit"),
            new Mission(Id = Guid.NewGuid(), Name = "Soins/santé/réeducation"),
            new Mission(Id = Guid.NewGuid(), Name = "Accompagnement à la parentalité"),
            new Mission(Id = Guid.NewGuid(), Name = "Accompagnement administratif"),
            new Mission(Id = Guid.NewGuid(), Name = "Ressource documentaire"),
            new Mission(Id = Guid.NewGuid(), Name = "Group de parole/Ateliers"),
            new Mission(Id = Guid.NewGuid(), Name = "Orientation"),
            new Mission(Id = Guid.NewGuid(), Name = "Prestataire")
            )
    }
}
