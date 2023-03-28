using System.ComponentModel.DataAnnotations.Schema;
using ELodowka.Data.Ingredients;
using ELodowka.Data.Recipes;

namespace ELodowka.Data.RecipeIngredients;

public class RecipeIngredient : IEntity
{
    public long Id { get; set; }
    public double Quantity { get; set; }
    public string QuantityType { get; set; } = default!;
    public long RecipeId { get; set; }
    public long IngredientId { get; set; }

    [ForeignKey(nameof(RecipeId))] public Recipe Recipe { get; set; } = null!;

    [ForeignKey(nameof(IngredientId))] public Ingredient Ingredient { get; set; } = null!;

}