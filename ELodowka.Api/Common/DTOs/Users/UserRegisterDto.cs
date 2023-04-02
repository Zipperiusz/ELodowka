namespace ELodowka.Api.Common.DTOs.Users;

public class UserRegisterDto
{
    public string Name { get; set; } = default!;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}