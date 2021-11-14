using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Products",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");
        }
    }
}
