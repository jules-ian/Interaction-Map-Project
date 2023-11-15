namespace DefaultNamespace;

public class MissionConfiguration : IEntityTypeConfiguration<Mission>
{
    public static void SeedMission(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mission>().HasData(
            new Mission(mId = 1, name = "Accueil de loisirs"),
            new Mission(mId = 2, name = "Petite enfance"),
            new Mission(mId = 3, name = "Répit"),
            new Mission(mId = 4, name = "Accueil occasionnel"),
            new Mission(mId = 5, name = "Scolarité"),
            new Mission(mId = 6, name = "Référent santé accueil inclusif (RSAI)"),
            new Mission(mId = 7, name = "Accueil de jour"),
            new Mission(mId = 8, name = "Accueil de nuit"),
            new Mission(mId = 9, name = "Soins/santé/réeducation"),
            new Mission(mId = 10, name = "Accompagnement à la parentalité"),
            new Mission(mId = 11, name = "Accompagnement administratif"),
            new Mission(mId = 12, name = "Ressource documentaire"),
            new Mission(mId = 13, name = "Group de parole/Ateliers"),
            new Mission(mId = 14, name = "Orientation"),
            new Mission(mId = 15, name = "Prestataire")
        );
    }
}
