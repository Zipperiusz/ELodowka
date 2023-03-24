namespace ELodowka.Api.Common.Exceptions;

public class ModelErrorException : Exception
{
    public ModelErrorException() : base("Nieprawidłowe dane na wejściu")
    {
    }
    
}