namespace ELodowka.Api.Common.Dto;

public class RecipeDto
{
    public string Name { get; set; }
    public List<string> Steps { get; set; } = new List<string>();
    public List<string> Timers { get; set; } = new List<string>();
    public string ImageURL { get; set; }
    public string OriginalURL { get; set; }
    public List<IngredientDto> Ingredients { get; set; } = new List<IngredientDto>();
}