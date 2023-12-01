namespace InteractiveMapProject.Contracts.Dtos.Geoapify;

public class GeoapifyRankDto
{
    public double Importance { get; set; }
    public double Popularity { get; set; }
    public int Confidence { get; set; }
    public int ConfidenceCityLevel { get; set; }
    public int ConfidenceStreetLevel { get; set; }
    public string MatchType { get; set; } = default!;

}
