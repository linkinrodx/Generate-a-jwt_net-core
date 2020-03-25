using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Habitantes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Habitantes", "Nombre" },
                values: new object[,]
                {
                    { new Guid("dc91db59-bef1-41bc-961d-0f561995c905"), 46000000, "España" },
                    { new Guid("c16c0e21-6a3c-46bd-a178-d401e3e13547"), 83000000, "Alemania" },
                    { new Guid("7c94004c-9e70-49fc-980f-fc1306e783d1"), 65000000, "Francia" },
                    { new Guid("d3bf5522-1820-4b68-bc46-b1c8d6f0a890"), 61000000, "Italia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
