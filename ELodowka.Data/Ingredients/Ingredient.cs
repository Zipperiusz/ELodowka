namespace ELodowka.Data.Ingredients;

public class Ingredient : IEntity
{
    public long Id { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

}