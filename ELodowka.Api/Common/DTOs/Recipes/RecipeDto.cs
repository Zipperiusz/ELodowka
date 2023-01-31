using ELodowka.Api.Common.DTOs.Step;
using ELodowka.Data.Steps;

namespace ELodowka.Api.Common.DTOs.Recipes;

public class RecipeDto
{
    public string Name { get; set; } = default!;
    public List<StepDto> Steps { get; set; } = new();
    public string ImageURL { get; set; } = default!;
    public string OriginalURL { get; set; } = default!;
    public long UserId { get; set; }
}