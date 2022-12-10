namespace ELodowka.Data.User;

public class User : IEntity
{
    public long Id { get; set;}
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
}