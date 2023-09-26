using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodDonationSystem.Migrations
{
    /// <inheritdoc />
    public partial class CreateHospitalBloodDonations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    idForBloodCollection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.idForBloodCollection);
                });

            migrationBuilder.CreateTable(
                name: "Donar",
                columns: table => new
                {
                    DonarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventoryidForBloodCollection = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donar", x => x.DonarId);
                    table.ForeignKey(
                        name: "FK_Donar_Inventory_InventoryidForBloodCollection",
                        column: x => x.InventoryidForBloodCollection,
                        principalTable: "Inventory",
                        principalColumn: "idForBloodCollection");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donar_InventoryidForBloodCollection",
                table: "Donar",
                column: "InventoryidForBloodCollection");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donar");

            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
