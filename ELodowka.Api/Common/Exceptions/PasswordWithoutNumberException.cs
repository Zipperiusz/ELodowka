namespace ELodowka.Api.Common.Exceptions;

public class PasswordWithoutNumberException : Exception
{
    public PasswordWithoutNumberException() : base("Hasło musi zawierać cyfrę.")
    {
    }
}