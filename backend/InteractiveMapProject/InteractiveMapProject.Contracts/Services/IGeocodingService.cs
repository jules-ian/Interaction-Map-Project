using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Services;

public interface IGeocodingService
{
    Task<Geolocation?> GetGeolocationFromAddressAsync(Address address);
}
