namespace ELodowka.Data.Users;

public interface IAuthRepository
{
    Task<ServiceResponse<long>> Register(User user, string password);
    Task<ServiceResponse<string>> Login(string Email, string password);
    Task<bool> UserExists(string Email);
    
}