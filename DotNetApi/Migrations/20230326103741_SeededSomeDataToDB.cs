using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetApi.Migrations
{
    /// <inheritdoc />
    public partial class SeededSomeDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Poets",
                columns: new[] { "Id", "BirthDay", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1355, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hafez" },
                    { 2, new DateTime(1207, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Molana" }
                });

            migrationBuilder.InsertData(
                table: "Poetries",
                columns: new[] { "Id", "Description", "Name", "PoetId" },
                values: new object[] { 1, "مثنوی معنوی", "Masnavi manavi", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Poetries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Poets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Poets",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
