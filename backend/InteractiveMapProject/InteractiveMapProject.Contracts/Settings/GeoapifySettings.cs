namespace InteractiveMapProject.Contracts.Settings;

public class GeoapifySettings
{
    public string ApiKey { get; set; } = default!;
    public string Url { get; set; } = default!;

    public GeoapifySettings(
       string apiKey,
       string url)
    {
        ApiKey = apiKey;
        Url = url;
    }

    public GeoapifySettings()
    {
    }
}
