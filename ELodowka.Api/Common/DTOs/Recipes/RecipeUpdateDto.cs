using ELodowka.Api.Common.DTOs.Step;

namespace ELodowka.Api.Common.DTOs.Recipes;

public class RecipeUpdateDto
{
    public string Name { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
    public string OriginalUrl { get; set; } = default!;
    public List<RecipeIngredientDto> Ingredients { get; set; } = new();
    public List<StepAddDto> Steps { get; set; } = new();
}