namespace FastDeliveryApi.Exceptions;

public class EmptyPhoneException : ApplicationException
{
    public EmptyPhoneException(string message) : base(message)
    {
    }
}