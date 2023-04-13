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
                new()
                {
                    Id = 51,
                    Name = "Jajka",
                    Type = IngredientType.Dairy
                }
                new()
                {
                    Id = 52,
                    Name = "Cebula",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 53,
                    Name = "Mąka",
                    Type = IngredientType.Grain,
                }
                                new()
                {
                    Id = 54,
                    Name = "Cukier",
                    Type = IngredientType.Spices,
                }
                                new()
                {
                    Id = 55,
                    Name = "Ryż",
                    Type = IngredientType.Grain,
                }
                new()
                {
                    Id = 56,
                    Name = "Keczup",
                    Type = IngredientType.Dips,
                }
                new()
                {
                    Id = 57,
                    Name = "Proszek do pieczenia",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 58,
                    Name = "Majonez",
                    Type = IngredientType.Dips,
                }
                new()
                {
                    Id = 59,
                    Name = "Śmietana",
                    Type = IngredientType.Dips,
                }
                new()
                {
                    Id = 60,
                    Name = "Liść Laurowy",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 61,
                    Name = "Majeranek",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 62,
                    Name = "Cynamon",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 63,
                    Name = "Olej rzepakowy",
                    Type = IngredientType.Oils,
                }
                new()
                {
                    Id = 64,
                    Name = "Musztarda",
                    Type = IngredientType.Dips,
                }
                new()
                {
                    Id = 65,
                    Name = "Soda Oczyszczona",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 66,
                    Name = "Tymianek",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 67,
                    Name = "Miód",
                    Type = IngredientType.Dips,
                }
                new()
                {
                    Id = 68,
                    Name = "Olej Słonecznikowy",
                    Type = IngredientType.Oils,
                }
                new()
                {
                    Id = 69,
                    Name = "Jogurt",
                    Type = IngredientType.Dairy,
                }
                new()
                {
                    Id = 70,
                    Name = "Pieczarki",
                    Type = IngredientType.Mushroom,
                }
                new()
                {
                    Id = 71,
                    Name = "Seler",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 72,
                    Name = "Por",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 73,
                    Name = "Cukinia",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 74,
                    Name = "Rzodkiewka",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 75,
                    Name = "Kalafior",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 76,
                    Name = "NikocadoAvokado",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 77,
                    Name = "Rukola",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 78,
                    Name = "Szparagi",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 79,
                    Name = "Bakłażan",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 80,
                    Name = "Kalarepa",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 81,
                    Name = "Bób",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 82,
                    Name = "Jarmuż",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 83,
                    Name = "Brukselka",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 84,
                    Name = "Podgrzybki",
                    Type = IngredientType.Mushroom,
                }
                new()
                {
                    Id = 85,
                    Name = "Borowki",
                    Type = IngredientType.Mushroom,
                }
                new()
                {
                    Id = 86,
                    Name = "Prawdziwki",
                    Type = IngredientType.Mushroom,
                }
                new()
                {
                    Id = 87,
                    Name = "Boczniaki",
                    Type = IngredientType.Mushroom,
                }
                new()
                {
                    Id = 88,
                    Name = "Rzepa",
                    Type = IngredientType.Vegetable,
                }
                new()
                {
                    Id = 89,
                    Name = "Opieńki",
                    Type = IngredientType.Mushroom,
                }
                new()
                {
                    Id = 90,
                    Name = "Jabłka",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 91,
                    Name = "Kiwi",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 92,
                    Name = "Cytryna",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 93,
                    Name = "Truskawki",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 94,
                    Name = "Pomarańcza",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 95,
                    Name = "Banan",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 96,
                    Name = "Śliwki",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 97,
                    Name = "Limonka",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 98,
                    Name = "Mango",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 99,
                    Name = "Winogron",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 100,
                    Name = "Morele",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 101,
                    Name = "Granat",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 102,
                    Name = "Grapefruit",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 103,
                    Name = "Kokos",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 104,
                    Name = "Arbuz",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 105,
                    Name = "Pitaja",
                    Type = IngredientType.Fruits,
                }
                new()
                {
                    Id = 106,
                    Name = "Kefir",
                    Type = IngredientType.Dairy,
                }
                new()
                {
                    Id = 107,
                    Name = "Serek Wiejski",
                    Type = IngredientType.Dairy,
                }
                new()
                {
                    Id = 108,
                    Name = "Skyr",
                    Type = IngredientType.Dairy,
                }
                new()
                {
                    Id = 109,
                    Name = "Ricotta",
                    Type = IngredientType.Dairy,
                }
                new()
                {
                    Id = 110,
                    Name = "Bita Śmietana",
                    Type = IngredientType.Dairy,
                }
                new()
                {
                    Id = 111,
                    Name = "Słonina",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 112,
                    Name = "Szynka Parmeńska",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 113,
                    Name = "Kabanosy",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 114,
                    Name = "Kaszanka",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 115,
                    Name = "Kiełbasa Podwawelska",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 116,
                    Name = "Mortadela",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 117,
                    Name = "Żeberka",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 118,
                    Name = "Serdelki",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 119,
                    Name = "Pasztet",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 120,
                    Name = "Skrzydełko Kurczaka",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 121,
                    Name = "Udko Kurczaka",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 122,
                    Name = "Schab wieprzowy",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 123,
                    Name = "Szyjka z indyka",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 124,
                    Name = "Kurze łapki",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 125,
                    Name = "Polędwica wieprzowa",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 126,
                    Name = "Mostek wieprzowy",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 127,
                    Name = "Antrykot",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 128,
                    Name = "Łopatka wieprzowa",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 129,
                    Name = "Goleń wieprzowa",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 130,
                    Name = "Filet Drobiowy",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 131,
                    Name = "Grzbiet Drobiowy",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 132,
                    Name = "Ćwiartka z Kurczaka",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 133,
                    Name = "Bułka tarta",
                    Type = IngredientType.Bread,
                }
                new()
                {
                    Id = 134,
                    Name = "Boczek",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 135,
                    Name = "Mięso Mielone",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 136,
                    Name = "Cały kurczak",
                    Type = IngredientType.Meat,
                }
                new()
                {
                    Id = 137,
                    Name = "Śledź",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 138,
                    Name = "Łosoś",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 139,
                    Name = "Tuńczyk",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 140,
                    Name = "Dorsz",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 141,
                    Name = "Dorsz",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 142,
                    Name = "Pstrąg",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 143,
                    Name = "Filety Rybne",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 144,
                    Name = "Krewetki",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 145,
                    Name = "Małże",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 146,
                    Name = "Kawior",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 147,
                    Name = "Kalmary",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 148,
                    Name = "Krab",
                    Type = IngredientType.Fish,
                }
                new()
                {
                    Id = 149,
                    Name = "Imbir",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 151,
                    Name = "Ziele Angielskie",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 152,
                    Name = "Kminek",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 153,
                    Name = "Kurkuma",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 154,
                    Name = "Rozmaryn",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 155,
                    Name = "Koper",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 156,
                    Name = "Mięta",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 157,
                    Name = "Kardamon",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 158,
                    Name = "Gałka Muszkatołowa",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 159,
                    Name = "Jaskółcze ziele",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 160,
                    Name = "Szakłak",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 161,
                    Name = "Ćwikła",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 162,
                    Name = "Curry",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 163,
                    Name = "Lubczyk",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 164,
                    Name = "Kolendra",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 165,
                    Name = "Kasza",
                    Type = IngredientType.Grain,
                }
                new()
                {
                    Id = 166,
                    Name = "Kakao",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 167,
                    Name = "Piwo",
                    Type = IngredientType.Bread,
                }
                new()
                {
                    Id = 168,
                    Name = "Bulion warzywny",
                    Type = IngredientType.delicatessen,
                }
                new()
                {
                    Id = 169,
                    Name = "bulion Drobiowy",
                    Type = IngredientType.delicatessen,
                }
                new()
                {
                    Id = 170,
                    Name = "Zakwas",
                    Type = IngredientType.delicatessen,
                }
                new()
                {
                    Id = 171,
                    Name = "Krasnoludzki Spirytus",
                    Type = IngredientType.Bread,
                }
                new()
                {
                    Id = 172,
                    Name = "Dmuchawiec",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 173,
                    Name = "Mutagen z Bazyliszka",
                    Type = IngredientType.delicatessen,
                }
                new()
                {
                    Id = 174,
                    Name = "Kwiat Dwugrotu",
                    Type = IngredientType.Spices,
                }
                new()
                {
                    Id = 175,
                    Name = "Liść Blekotu",
                    Type = IngredientType.Spices,
                }
            });
    }
}