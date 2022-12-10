namespace ELodowka.Api.Common.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException() : base("Not found.")
    {
        
    }
}