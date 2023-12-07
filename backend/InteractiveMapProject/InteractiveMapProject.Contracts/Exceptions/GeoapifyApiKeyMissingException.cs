namespace InteractiveMapProject.Contracts.Exceptions;

public class GeoapifyApiKeyMissingException : Exception
{
    public GeoapifyApiKeyMissingException(string message) : base(message)
    {
    }
}
