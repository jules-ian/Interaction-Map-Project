using InteractiveMapProject.Contracts.Services;
using System.Text.Json;

namespace InteractiveMapProject.Services;

public class HttpService : IHttpService
{
    private readonly HttpClient _httpClient;

    public HttpService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetAsync<T>(string url, Dictionary<string, string>? parameters = null)
    {
        string urlWithParams = AddParameters(url, parameters);

        var response = await _httpClient.GetAsync(urlWithParams);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(responseBody);
    }

    private string AddParameters(string baseUrl, Dictionary<string, string>? parameters)
    {
        if (parameters == null || parameters.Count == 0)
        {
            return baseUrl;
        }

        var queryString = string.Join("&", parameters.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));

        if (baseUrl.Contains("?"))
        {
            return $"{baseUrl}{queryString}";
        }
        else
        {
            return $"{baseUrl}?{queryString}";
        }
    }
}
