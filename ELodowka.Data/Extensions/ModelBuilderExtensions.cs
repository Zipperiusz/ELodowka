using ELodowka.Data.Enums;
using ELodowka.Data.Ingredients;
using Microsoft.EntityFrameworkCore;

namespace ELodowka.Data.Extensions;

public static class ModelBuilderExtensions
{
    public static void SeedDatabase(this ModelBuilder modelBuilder)
    {
        SeedIngredients(modelBuilder);
    }

    private static void SeedIngredients(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>().HasData(
            new List<Ingredient>
            {
                new()
                {
                    Id = 1,
                    Name = "Marchewka",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 2,
                    Name = "Pomidor",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 3,
                    Name = "Cebula",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 4,
                    Name = "Szynka",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 5,
                    Name = "Kiełbasa śląska",
                    Type = IngredientType.Meat
                }
            });
    }
}