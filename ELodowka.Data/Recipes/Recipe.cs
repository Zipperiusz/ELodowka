using ELodowka.Data.Ingredients;
using ELodowka.Data.Steps;
using ELodowka.Data.Users;
using Timer = ELodowka.Data.Timers.Timer;

namespace ELodowka.Data.Recipes;


public class Recipe : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<Step> Steps { get; set; } = new List<Step>();
    public List<Timer> Timers { get; set; } = new List<Timer>();
    public string ImageUrl { get; set; }
    public string OriginalUrl { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public List<long> IngredientsId { get; set; } = new List<long>();
    public User User { get; set; }
    public long UserId { get; set; }

}