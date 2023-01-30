using ELodowka.Data.Ingredients;

namespace ELodowka.Api.Common.Dto;

public class UserDto
{
    public string Email { get; set; }
    public List<IngredientDto> IngredientsList { get; set; }
    public List<RecipeDto> RecipesList { get; set; }
}