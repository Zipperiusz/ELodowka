using ELodowka.Data.Enums;
using ELodowka.Data.RecipeIngredients;

namespace ELodowka.Data.Ingredients;

public class Ingredient : IEntity
{
    public string Name { get; set; } = default!;
    public IngredientType Type { get; set; } = default!;
    public long Id { get; set; }
    
    public List<RecipeIngredient> RecipeIngredients { get; set; } = new();
}