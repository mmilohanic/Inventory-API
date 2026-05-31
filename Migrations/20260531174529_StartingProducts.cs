using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_API.Migrations
{
    /// <inheritdoc />
    public partial class StartingProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ItemName", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 31, 15, 46, 18, 0, DateTimeKind.Utc), "Mrežni kabel U/FTP Cat.6A 5m", "Ethernet kabel", 6.99m, 25 },
                    { 2, new DateTime(2025, 5, 31, 15, 46, 18, 0, DateTimeKind.Utc), "8-portni gigabit switch", "Mrežni preklopnik", 30.00m, 5 },
                    { 3, new DateTime(2025, 5, 31, 15, 46, 18, 0, DateTimeKind.Utc), "Monofazni, 16A, B karakteristika, 10kA", "Strujni prekidač", 5.00m, 15 },
                    { 4, new DateTime(2025, 5, 31, 15, 46, 18, 0, DateTimeKind.Utc), "FG16(OR)16, bakar", "Kabel 4x50", 80.00m, 35 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
