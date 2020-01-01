using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    Document = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    ProviderType = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Zipcode = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Street = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    Number = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    Complement = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    District = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    City = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    State = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    ProviderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    Desciption = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(6,2)", maxLength: 400, nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProviderId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProviderId",
                table: "Addresses",
                column: "ProviderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProviderId",
                table: "Products",
                column: "ProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
