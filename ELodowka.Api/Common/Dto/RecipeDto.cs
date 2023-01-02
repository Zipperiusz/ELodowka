using ELodowka.Data.Step;
using Timer = ELodowka.Data.Timer.Timer;

namespace ELodowka.Api.Common.Dto;

public class RecipeDto
{
    public string Name { get; set; }
    public List<Step> Steps { get; set; } = new List<Step>();
    public List<Timer> Timers { get; set; } = new List<Timer>();
    public string ImageURL { get; set; }
    public string OriginalURL { get; set; }
    public List<IngredientDto> Ingredients { get; set; } = new List<IngredientDto>();
}