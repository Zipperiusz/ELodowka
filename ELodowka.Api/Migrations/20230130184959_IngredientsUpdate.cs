using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELodowka.Api.Migrations
{
    public partial class IngredientsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Users_userId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_userId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_userId",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Recipes",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "OriginalURL",
                table: "Recipes",
                newName: "OriginalUrl");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Recipes",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Ingredients",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_userId",
                table: "Ingredients",
                newName: "IX_Ingredients_UserId");

            migrationBuilder.AddColumn<long>(
                name: "UserId1",
                table: "Recipes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Ingredients",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId1",
                table: "Recipes",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Users_UserId",
                table: "Ingredients",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId1",
                table: "Recipes",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Users_UserId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId1",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_UserId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Recipes",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "OriginalUrl",
                table: "Recipes",
                newName: "OriginalURL");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Recipes",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Ingredients",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_UserId",
                table: "Ingredients",
                newName: "IX_Ingredients_userId");

            migrationBuilder.AlterColumn<long>(
                name: "userId",
                table: "Ingredients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_userId",
                table: "Recipes",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Users_userId",
                table: "Ingredients",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_userId",
                table: "Recipes",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
