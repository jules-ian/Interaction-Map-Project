namespace InteractiveMapProject.Contracts.Services;

public interface IHttpService
{
    Task<T?> GetAsync<T>(string url, Dictionary<string, string>? parameters = null);
}
