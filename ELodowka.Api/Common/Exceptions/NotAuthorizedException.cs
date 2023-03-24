namespace ELodowka.Api.Common.Exceptions;

public class NotAuthorizedException : Exception
{
    public NotAuthorizedException() : base("Użytkownik jest niezautoryzowany")
    {
        
    }
}