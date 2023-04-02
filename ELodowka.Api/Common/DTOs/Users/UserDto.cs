using ELodowka.Api.Common.DTOs.Ingredients;
using ELodowka.Api.Common.DTOs.Recipes;

namespace ELodowka.Api.Common.DTOs.Users;

public class UserDto
{
    public string Email { get; set; } = default!;
    public string Name { get; set; } = default!;
    public List<IngredientDto> IngredientsList { get; set; } = new();
    public List<RecipeDto> RecipesList { get; set; } = new();
}