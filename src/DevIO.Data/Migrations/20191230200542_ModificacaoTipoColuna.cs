using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class ModificacaoTipoColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                nullable: true);
        }
    }
}
