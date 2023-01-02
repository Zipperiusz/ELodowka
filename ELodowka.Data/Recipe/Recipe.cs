using ELodowka.Data.Ingredients;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Data.Recipe;

[Keyless]
public class Recipe : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<string> Steps { get; set; } = new List<string>();
    public List<string> Timers { get; set; } = new List<string>();
    public string ImageURL { get; set; }
    public string OriginalURL { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}