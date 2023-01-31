namespace ELodowka.Api.Common.Exceptions;

public class NotAuthorizedException : Exception
{
    public NotAuthorizedException() : base("User is not authorized.")
    {
        
    }
}