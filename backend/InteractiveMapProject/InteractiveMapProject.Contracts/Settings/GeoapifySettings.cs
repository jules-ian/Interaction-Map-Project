namespace InteractiveMapProject.Contracts.Settings;

public class GeoapifySettings
{
    public string ApiKey { get; set; }

    public GeoapifySettings(
       string apiKey)
    {
        ApiKey = apiKey;
    }

    public GeoapifySettings()
    {
    }
}
