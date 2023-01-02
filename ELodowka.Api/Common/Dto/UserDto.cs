using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipe;

namespace ELodowka.Api.Common.Dto;

public class UserDto
{
    public List<Ingredient> IngredientsList { get; set; }
    public List<Recipe> RecipesList { get; set; }
    public string Email { get; set; }
}