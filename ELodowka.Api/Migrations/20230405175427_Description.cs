using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELodowka.Api.Migrations
{
    public partial class Description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OriginalUrl",
                table: "Recipes",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Recipes",
                newName: "OriginalUrl");
        }
    }
}
