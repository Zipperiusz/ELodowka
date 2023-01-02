using ELodowka.Data.Ingredients;
using ELodowka.Data.Step;

namespace ELodowka.Data.Recipe;


public class Recipe : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<Step.Step> Steps { get; set; } = new List<Step.Step>();
    public List<Timer.Timer> Timers { get; set; } = new List<Timer.Timer>();
    public string ImageURL { get; set; }
    public string OriginalURL { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public User.User user { get; set; }
}