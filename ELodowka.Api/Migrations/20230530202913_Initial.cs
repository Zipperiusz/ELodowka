using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELodowka.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PasswordHash = table.Column<byte[]>(type: "longblob", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "longblob", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<double>(type: "double", nullable: false),
                    QuantityType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RecipeId = table.Column<long>(type: "bigint", nullable: false),
                    IngredientId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 1L, "Marchewka", 0 },
                    { 2L, "Pomidor", 0 },
                    { 3L, "Cebula", 0 },
                    { 4L, "Szynka", 1 },
                    { 5L, "Kiełbasa śląska", 1 },
                    { 6L, "Buraki", 0 },
                    { 7L, "Papryka", 0 },
                    { 8L, "Sałata", 0 },
                    { 9L, "Ogórek", 0 },
                    { 10L, "Ziemniaki", 0 },
                    { 11L, "Bataty", 0 },
                    { 12L, "Kapusta", 0 },
                    { 13L, "Kapary", 0 },
                    { 14L, "Dynia", 0 },
                    { 15L, "Fasola", 0 },
                    { 16L, "Karkówka", 1 },
                    { 17L, "Pierś z Kurczaka", 1 },
                    { 18L, "Salami", 1 },
                    { 19L, "Kiełbasa Żywiecka", 1 },
                    { 20L, "Stek Wołowy", 1 },
                    { 21L, "Wieprzowina Mielona", 1 },
                    { 22L, "Pierś z Kaczki", 1 },
                    { 23L, "Bekon", 1 },
                    { 24L, "Noga z Kurczaka", 1 },
                    { 25L, "Pierś z Indyka", 1 },
                    { 26L, "Mleko 2%", 2 },
                    { 27L, "Mleko 1.5%", 2 },
                    { 28L, "Mleko 3.2%", 2 },
                    { 29L, "Ser Gouda", 2 },
                    { 30L, "Ser Mozarella", 2 },
                    { 31L, "Ser Parmezan", 2 },
                    { 32L, "Ser Mascarponne", 2 },
                    { 33L, "Ser Fetta", 2 },
                    { 34L, "Maślanka", 2 },
                    { 35L, "Masło", 2 },
                    { 36L, "Chleb Pszenny", 3 },
                    { 37L, "Chleb Żytni", 3 },
                    { 38L, "Chleb Na Zakwasie", 3 },
                    { 39L, "Pumpernikiel", 3 },
                    { 40L, "Chleb Orkiszowy", 3 },
                    { 41L, "Makaron Spaghetti", 4 },
                    { 42L, "Makaron Pene", 4 },
                    { 43L, "Makaron Tagiatelle", 4 },
                    { 44L, "Sól", 5 },
                    { 45L, "Pieprz", 5 },
                    { 46L, "Paryka Słodka", 5 },
                    { 47L, "Papryka Ostra", 5 },
                    { 48L, "Czosnek Mielony", 5 },
                    { 49L, "Oregano", 5 },
                    { 50L, "Bazylia", 5 },
                    { 51L, "Jajka", 2 },
                    { 52L, "Cebula", 0 },
                    { 53L, "Mąka", 6 },
                    { 54L, "Cukier", 5 },
                    { 55L, "Ryż", 6 },
                    { 56L, "Keczup", 7 },
                    { 57L, "Proszek do pieczenia", 5 },
                    { 58L, "Majonez", 7 },
                    { 59L, "Śmietana", 7 },
                    { 60L, "Liść Laurowy", 5 },
                    { 61L, "Majeranek", 5 },
                    { 62L, "Cynamon", 5 },
                    { 63L, "Olej rzepakowy", 8 },
                    { 64L, "Musztarda", 7 },
                    { 65L, "Soda Oczyszczona", 5 },
                    { 66L, "Tymianek", 5 },
                    { 67L, "Miód", 7 },
                    { 68L, "Olej Słonecznikowy", 8 },
                    { 69L, "Jogurt", 2 },
                    { 70L, "Pieczarki", 9 },
                    { 71L, "Seler", 0 },
                    { 72L, "Por", 0 },
                    { 73L, "Cukinia", 0 },
                    { 74L, "Rzodkiewka", 0 },
                    { 75L, "Kalafior", 0 },
                    { 76L, "NikocadoAvokado", 0 },
                    { 77L, "Rukola", 0 },
                    { 78L, "Szparagi", 0 },
                    { 79L, "Bakłażan", 0 },
                    { 80L, "Kalarepa", 0 },
                    { 81L, "Bób", 0 },
                    { 82L, "Jarmuż", 0 },
                    { 83L, "Brukselka", 0 },
                    { 84L, "Podgrzybki", 9 },
                    { 85L, "Borowki", 9 },
                    { 86L, "Prawdziwki", 9 },
                    { 87L, "Boczniaki", 9 },
                    { 88L, "Rzepa", 0 },
                    { 89L, "Opieńki", 9 },
                    { 90L, "Jabłka", 10 },
                    { 91L, "Kiwi", 10 },
                    { 92L, "Cytryna", 10 },
                    { 93L, "Truskawki", 10 },
                    { 94L, "Pomarańcza", 10 },
                    { 95L, "Banan", 10 },
                    { 96L, "Śliwki", 10 },
                    { 97L, "Limonka", 10 },
                    { 98L, "Mango", 10 },
                    { 99L, "Winogron", 10 },
                    { 100L, "Morele", 10 },
                    { 101L, "Granat", 10 },
                    { 102L, "Grapefruit", 10 },
                    { 103L, "Kokos", 10 },
                    { 104L, "Arbuz", 10 },
                    { 105L, "Pitaja", 10 },
                    { 106L, "Kefir", 2 },
                    { 107L, "Serek Wiejski", 2 },
                    { 108L, "Skyr", 2 },
                    { 109L, "Ricotta", 2 },
                    { 110L, "Bita Śmietana", 2 },
                    { 111L, "Słonina", 1 },
                    { 112L, "Szynka Parmeńska", 1 },
                    { 113L, "Kabanosy", 1 },
                    { 114L, "Kaszanka", 1 },
                    { 115L, "Kiełbasa Podwawelska", 1 },
                    { 116L, "Mortadela", 1 },
                    { 117L, "Żeberka", 1 },
                    { 118L, "Serdelki", 1 },
                    { 119L, "Pasztet", 1 },
                    { 120L, "Skrzydełko Kurczaka", 1 },
                    { 121L, "Udko Kurczaka", 1 },
                    { 122L, "Schab wieprzowy", 1 },
                    { 123L, "Szyjka z indyka", 1 },
                    { 124L, "Kurze łapki", 1 },
                    { 125L, "Polędwica wieprzowa", 1 },
                    { 126L, "Mostek wieprzowy", 1 },
                    { 127L, "Antrykot", 1 },
                    { 128L, "Łopatka wieprzowa", 1 },
                    { 129L, "Goleń wieprzowa", 1 },
                    { 130L, "Filet Drobiowy", 1 },
                    { 131L, "Grzbiet Drobiowy", 1 },
                    { 132L, "Ćwiartka z Kurczaka", 1 },
                    { 133L, "Bułka tarta", 3 },
                    { 134L, "Boczek", 1 },
                    { 135L, "Mięso Mielone", 1 },
                    { 136L, "Cały kurczak", 1 },
                    { 137L, "Śledź", 11 },
                    { 138L, "Łosoś", 11 },
                    { 139L, "Tuńczyk", 11 },
                    { 140L, "Dorsz", 11 },
                    { 141L, "Dorsz", 11 },
                    { 142L, "Pstrąg", 11 },
                    { 143L, "Filety Rybne", 11 },
                    { 144L, "Krewetki", 11 },
                    { 145L, "Małże", 11 },
                    { 146L, "Kawior", 11 },
                    { 147L, "Kalmary", 11 },
                    { 148L, "Krab", 11 },
                    { 149L, "Imbir", 5 },
                    { 151L, "Ziele Angielskie", 5 },
                    { 152L, "Kminek", 5 },
                    { 153L, "Kurkuma", 5 },
                    { 154L, "Rozmaryn", 5 },
                    { 155L, "Koper", 5 },
                    { 156L, "Mięta", 5 },
                    { 157L, "Kardamon", 5 },
                    { 158L, "Gałka Muszkatołowa", 5 },
                    { 159L, "Jaskółcze ziele", 5 },
                    { 160L, "Szakłak", 5 },
                    { 161L, "Ćwikła", 5 },
                    { 162L, "Curry", 5 },
                    { 163L, "Lubczyk", 5 },
                    { 164L, "Kolendra", 5 },
                    { 165L, "Kasza", 6 },
                    { 166L, "Kakao", 5 },
                    { 167L, "Piwo", 3 },
                    { 168L, "Bulion warzywny", 12 },
                    { 169L, "bulion Drobiowy", 12 },
                    { 170L, "Zakwas", 12 },
                    { 171L, "Krasnoludzki Spirytus", 3 },
                    { 172L, "Dmuchawiec", 5 },
                    { 173L, "Mutagen z Bazyliszka", 12 },
                    { 174L, "Kwiat Dwugrotu", 5 },
                    { 175L, "Liść Blekotu", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_RecipeId",
                table: "Steps",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
