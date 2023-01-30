using ELodowka.Data.Steps;
using Timer = ELodowka.Data.Timers.Timer;

namespace ELodowka.Api.Common.Dto;

public class RecipeDto
{
    public string Name { get; set; }
    public List<Step> Steps { get; set; } = new List<Step>();
    public List<Timer> Timers { get; set; } = new List<Timer>();
    public string ImageURL { get; set; }
    public string OriginalURL { get; set; }
    public List<long> IngredientsId { get; set; } = new List<long>();
    public long UserId { get; set; }

}