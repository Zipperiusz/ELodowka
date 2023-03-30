namespace ELodowka.Api.Common.DTOs.Recipes;

public class RecipeIngredientDto
{
    public long Id { get; set; }
    public double Quantity { get; set; }
    public string QuantityType { get; set; } = default!;
    public long IngredientId { get; set; }
    public string? Name { get; set; }
}