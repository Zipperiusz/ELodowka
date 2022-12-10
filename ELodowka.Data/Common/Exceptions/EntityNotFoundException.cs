namespace ELodowka.Data.Common.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException() : base("Entity was not found.")
    {
    }
}