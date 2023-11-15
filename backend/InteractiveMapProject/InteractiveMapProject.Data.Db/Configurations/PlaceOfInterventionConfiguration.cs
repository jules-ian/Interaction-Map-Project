namespace DefaultNamespace;

public class PlaceOfInterventionConfiguration : IEntityTypeConfiguration<PlaceOfIntervention>
{
    public static void SeedPlaceOfIntervention(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlaceOfIntervention>().HasData(
            new PlaceOfIntervention(poiId = 1, name = "Domicile"),
            new PlaceOfIntervention(poiId = 2, name = "EAJE"),
            new PlaceOfIntervention(poiId = 3, name = "École"),
            new PlaceOfIntervention(poiId = 4, name = "Cabinet")
        );
    }
}
