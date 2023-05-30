using ELodowka.Api.Common.DTOs.Step;
using ELodowka.Api.Common.DTOs.Users;

namespace ELodowka.Api.Common.DTOs.Recipes;

public class RecipeDto
{
    public long Id { get; set; }

    public string Name { get; set; } = default!;
    public List<StepDto> Steps { get; set; } = new();
    public string ImageUrl { get; set; } = default!;
    public string Description { get; set; } = default!;
    public List<RecipeIngredientDto> Ingredients { get; set; } = new();

    public UserRecipeDto User { get; set; } = null!;
}