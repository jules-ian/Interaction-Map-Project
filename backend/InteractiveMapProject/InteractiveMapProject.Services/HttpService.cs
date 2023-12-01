using InteractiveMapProject.Contracts.Services;
using System.Text.Json;
using System.Web;
using System.Xml.Linq;

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

        var queryString = string.Join("&", parameters.Select(kvp => $"{HttpUtility.HtmlEncode(kvp.Key)}={HttpUtility.HtmlEncode(kvp.Value)}"));

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
