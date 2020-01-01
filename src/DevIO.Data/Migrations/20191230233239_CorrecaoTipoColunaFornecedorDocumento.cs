using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class CorrecaoTipoColunaFornecedorDocumento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
