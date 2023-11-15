namespace DefaultNamespace;

public class AudienceConfiguration : IEntityTypeConfiguration<Audience>
{
    public static void SeedAudience(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Audience>().HasData(
            new Audience(aId = 1, name = "0-3 ans"),
            new Audience(aId = 2, name = "3-6 ans"),
            new Audience(aId = 3, name = "6-12 ans"),
            new Audience(aId = 4, name = "12-18 ans"),
            new Audience(aId = 5, name = "Parents"),
            new Audience(aId = 6, name = "Professionnels")
        );
    }
}
