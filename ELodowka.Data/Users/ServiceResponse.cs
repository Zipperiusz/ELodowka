namespace ELodowka.Data.Users;

public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public T? Name { get; set; }
    public bool Success { get; set; } = true;
    public string Message { get; set; } = string.Empty;
}