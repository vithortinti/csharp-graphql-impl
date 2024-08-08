using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Study.GraphQL.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    Complement = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            Guid[] addressesIds = new Guid[5]
                .Select(x => x = Guid.NewGuid())
                .ToArray();
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "State", "Country", "Street", "Complement", "ZipCode" },
                values: new object[,]
                {
                    { addressesIds[0], "Belo Horizonte", "MG", "Brazil", "Rua das Flores", "Casa 10", "30100-000" },
                    { addressesIds[1], "Curitiba", "PR", "Brazil", "Avenida Paraná", "Sala 303", "80000-000" },
                    { addressesIds[2], "Porto Alegre", "RS", "Brazil", "Rua da Praia", "Loja A", "90000-000" },
                    { addressesIds[3], "Salvador", "BA", "Brazil", "Avenida Oceânica", "Cobertura", "40100-000" },
                    { addressesIds[4], "Fortaleza", "CE", "Brazil", "Rua do Sol", "Apt 202", "60000-000" }
                });
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "FirstName", "LastName", "BirthDate", "AddressId" },
                values: new object[,] {
                    { Guid.NewGuid(), "Carlos", "Pereira", new DateTime(1980, 2, 20).ToUniversalTime(), addressesIds[0] },
                    { Guid.NewGuid(), "Ana", "Silva", new DateTime(1990, 5, 10).ToUniversalTime(), addressesIds[1] },
                    { Guid.NewGuid(), "João", "Santos", new DateTime(2000, 8, 30).ToUniversalTime(), addressesIds[2] },
                    { Guid.NewGuid(), "Maria", "Oliveira", new DateTime(1970, 11, 15).ToUniversalTime(), addressesIds[3] },
                    { Guid.NewGuid(), "Pedro", "Souza", new DateTime(1960, 12, 25).ToUniversalTime(), addressesIds[4] }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
