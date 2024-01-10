namespace InteractiveMapProject.Contracts.Exceptions;

public class InvalidAddressException : Exception
{
    public InvalidAddressException(string message) : base(message)
    {
    }
}
