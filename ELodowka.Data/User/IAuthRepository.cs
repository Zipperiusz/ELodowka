namespace ELodowka.Data.User;

public interface IAuthRepository
{
    Task<ServiceResponse<long>> Register(User user, string password);
    Task<ServiceResponse<string>> Login(string Email, string password);
    Task<bool> UserExists(string Email);
    
}