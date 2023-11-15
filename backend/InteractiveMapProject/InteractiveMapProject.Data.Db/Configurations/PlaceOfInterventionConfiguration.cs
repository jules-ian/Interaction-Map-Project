Namespace DefaultNamespace;

public class PlaceOfInterventionConfiguration : IEntityTypeConfiguration<PlaceOfIntervention>
{
    public static void SeedPlaceOfIntervention(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlaceOfIntervention>().HasData(
            new PlaceOfIntervention(PoiId = 1, Name = "Domicile"),
            new PlaceOfIntervention(PoiId = 2, Name = "EAJE"),
            new PlaceOfIntervention(PoiId = 3, Name = "École"),
            new PlaceOfIntervention(PoiId = 4, Name = "Cabinet")
        );
    }
}
