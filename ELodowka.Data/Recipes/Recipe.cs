using System.ComponentModel.DataAnnotations.Schema;
using ELodowka.Data.RecipeIngredients;
using ELodowka.Data.Steps;
using ELodowka.Data.Users;

namespace ELodowka.Data.Recipes;

public class Recipe : IEntity
{
    public string Name { get; set; } = default!;
    public List<Step> Steps { get; set; } = new();
    public string ImageUrl { get; set; } = default!;
    public string OriginalUrl { get; set; } = default!;
    public long UserId { get; set; }

    public List<RecipeIngredient> RecipeIngredients { get; set; } = new();

    [ForeignKey(nameof(UserId))] public User User { get; set; } = null!;

    public long Id { get; set; }
}