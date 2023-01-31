using System.ComponentModel.DataAnnotations.Schema;
using ELodowka.Data.Recipes;

namespace ELodowka.Data.Steps;

public class Step : IEntity
{
    public string Name { get; set; } = default!;
    public int Time { get; set; }
    public long Id { get; set; }
    public long RecipeId { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public Recipe Recipe { get; set; } = null!;
}