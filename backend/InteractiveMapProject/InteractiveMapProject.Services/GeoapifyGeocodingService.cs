using InteractiveMapProject.Contracts.Dtos.Geoapify;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Exceptions;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.Settings;
using Microsoft.Extensions.Options;

namespace InteractiveMapProject.Services;

public class GeoapifyGeocodingService : IGeocodingService
{
    private readonly GeoapifySettings _settings;
    private readonly IHttpService _httpService;

    public GeoapifyGeocodingService(IOptions<GeoapifySettings> settings, IHttpService httpService)
    {
        _settings = settings.Value;
        _httpService = httpService;
    }

    public async Task<Geolocation?> GetGeolocationFromAddressAsync(Address address)
    {
        var parameters = new Dictionary<string, string>();
        parameters.Add("apiKey", _settings.ApiKey);
        parameters.Add("text", string.Format("{0}, {1} {2}", address.Street, address.City, address.PostalCode));
        GeoapifyResponseDto? geoapifyResponse;
        try
        {
            geoapifyResponse = await _httpService.GetAsync<GeoapifyResponseDto>(_settings.Url, parameters);
        }
        catch (HttpRequestException)
        {
            throw new GeoapifyApiKeyMissingException("Geoapify API key is missing.");
        };

        if (geoapifyResponse == null || geoapifyResponse.Features.Count() == 0)
        {
            return null;
        }
        GeoapifyFeatureDto feature = geoapifyResponse.Features.First();
        return new Geolocation(feature.Properties.Lon, feature.Properties.Lat);
    }
}
