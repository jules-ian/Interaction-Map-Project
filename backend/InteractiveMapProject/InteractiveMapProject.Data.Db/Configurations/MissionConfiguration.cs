Namespace DefaultNamespace;

public class MissionConfiguration : IEntityTypeConfiguration<Mission>
{
    public static void SeedMission(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mission>().HasData(
            new Mission(MId = 1, Name = "Accueil de loisirs"),
            new Mission(MId = 2, Name = "Petite enfance"),
            new Mission(MId = 3, Name = "Répit"),
            new Mission(MId = 4, Name = "Accueil occasionnel"),
            new Mission(MId = 5, Name = "Scolarité"),
            new Mission(MId = 6, Name = "Référent santé accueil inclusif (RSAI)"),
            new Mission(MId = 7, Name = "Accueil de jour"),
            new Mission(MId = 8, Name = "Accueil de nuit"),
            new Mission(MId = 9, Name = "Soins/santé/réeducation"),
            new Mission(MId = 10, Name = "Accompagnement à la parentalité"),
            new Mission(MId = 11, Name = "Accompagnement administratif"),
            new Mission(MId = 12, Name = "Ressource documentaire"),
            new Mission(MId = 13, Name = "Group de parole/Ateliers"),
            new Mission(MId = 14, Name = "Orientation"),
            new Mission(MId = 15, Name = "Prestataire")
        );
    }
}
