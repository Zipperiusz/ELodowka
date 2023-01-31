namespace ELodowka.Api.Common.DTOs.Ingredients;

public class IngredientDto
{
    public int Quantity { get; set; }
    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
}