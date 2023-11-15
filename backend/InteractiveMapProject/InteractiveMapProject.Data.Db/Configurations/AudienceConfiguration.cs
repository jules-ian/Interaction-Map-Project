Namespace DefaultNamespace;

public class AudienceConfiguration : IEntityTypeConfiguration<Audience>
{
    public static void SeedAudience(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Audience>().HasData(
            new Audience(AId = 1, Name = "0-3 ans"),
            new Audience(AId = 2, Name = "3-6 ans"),
            new Audience(AId = 3, Name = "6-12 ans"),
            new Audience(AId = 4, Name = "12-18 ans"),
            new Audience(AId = 5, Name = "Parents"),
            new Audience(AId = 6, Name = "Professionnels")
        );
    }
}
