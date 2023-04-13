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
                },
                new()
                {
                    Id = 6,
                    Name = "Buraki",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 7,
                    Name = "Papryka",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 8,
                    Name = "Sałata",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 9,
                    Name = "Ogórek",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 10,
                    Name = "Ziemniaki",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 11,
                    Name = "Bataty",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 12,
                    Name = "Kapusta",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 13,
                    Name = "Kapary",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 14,
                    Name = "Dynia",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 15,
                    Name = "Fasola",
                    Type = IngredientType.Vegetable
                },
                new()
                {
                    Id = 16,
                    Name = "Karkówka",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 17,
                    Name = "Pierś z Kurczaka",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 18,
                    Name = "Salami",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 19,
                    Name = "Kiełbasa Żywiecka",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 20,
                    Name = "Stek Wołowy",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 21,
                    Name = "Wieprzowina Mielona",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 22,
                    Name = "Pierś z Kaczki",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 23,
                    Name = "Bekon",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 24,
                    Name = "Noga z Kurczaka",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 25,
                    Name = "Pierś z Indyka",
                    Type = IngredientType.Meat
                },
                new()
                {
                    Id = 26,
                    Name = "Mleko 2%",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 27,
                    Name = "Mleko 1.5%",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 28,
                    Name = "Mleko 3.2%",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 29,
                    Name = "Ser Gouda",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 30,
                    Name = "Ser Mozarella",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 31,
                    Name = "Ser Parmezan",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 32,
                    Name = "Ser Mascarponne",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 33,
                    Name = "Ser Fetta",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 34,
                    Name = "Maślanka",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 35,
                    Name = "Masło",
                    Type = IngredientType.Dairy
                },
                new()
                {
                    Id = 36,
                    Name = "Chleb Pszenny",
                    Type = IngredientType.Bread
                },
                new()
                {
                    Id = 37,
                    Name = "Chleb Żytni",
                    Type = IngredientType.Bread
                },
                new()
                {
                    Id = 38,
                    Name = "Chleb Na Zakwasie",
                    Type = IngredientType.Bread
                },
                new()
                {
                    Id = 39,
                    Name = "Pumpernikiel",
                    Type = IngredientType.Bread
                },
                new()
                {
                    Id = 40,
                    Name = "Chleb Orkiszowy",
                    Type = IngredientType.Bread
                },
                new()
                {
                    Id = 41,
                    Name = "Makaron Spaghetti",
                    Type = IngredientType.Pasta
                },
                new()
                {
                    Id = 42,
                    Name = "Makaron Pene",
                    Type = IngredientType.Pasta
                },
                new()
                {
                    Id = 43,
                    Name = "Makaron Tagiatelle",
                    Type = IngredientType.Pasta
                },
                new()
                {
                    Id = 44,
                    Name = "Sól",
                    Type = IngredientType.Spices
                },
                new()
                {
                    Id = 45,
                    Name = "Pieprz",
                    Type = IngredientType.Spices
                },
                new()
                {
                    Id = 46,
                    Name = "Pparyka Słodka",
                    Type = IngredientType.Spices
                },
                new()
                {
                    Id = 47,
                    Name = "Papryka Ostra",
                    Type = IngredientType.Spices
                },
                new()
                {
                    Id = 48,
                    Name = "Czosnek Mielony",
                    Type = IngredientType.Spices
                },
                new()
                {
                    Id = 49,
                    Name = "Oregano",
                    Type = IngredientType.Spices
                },
                new()
                {
                    Id = 50,
                    Name = "Bazylia",
                    Type = IngredientType.Spices
                }
            });
    }
}