namespace ELodowka.Api.Common.DTOs.Ingredients;

public class IngredientListDto
{
    public long Id { get; set; }

    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
}