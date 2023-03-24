namespace ELodowka.Api.Common.Exceptions;

public class TooShortPasswordException
    : Exception
{
    public TooShortPasswordException() : base("Hasło musi zawierać przynajmniej 8 znaków.")
    {
    }
}