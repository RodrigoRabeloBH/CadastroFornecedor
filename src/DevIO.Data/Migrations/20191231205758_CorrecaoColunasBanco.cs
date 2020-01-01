using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class CorrecaoColunasBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Document",
                table: "Providers",
                type: "varchar(14)",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Addresses",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Document",
                table: "Providers",
                type: "int",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<int>(
                name: "Zipcode",
                table: "Addresses",
                type: "int",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldMaxLength: 8);
        }
    }
}
