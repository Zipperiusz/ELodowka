using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipes;

namespace ELodowka.Data.Users;

public class User : IEntity
{
    public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
    public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public List<Recipe> Recipes { get; set; } = new();
    public long Id { get; set; }
}