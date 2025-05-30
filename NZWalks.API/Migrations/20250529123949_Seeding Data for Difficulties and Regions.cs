using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("16bdc40b-10a3-4641-8baf-cbf22181cfbc"), "Easy" },
                    { new Guid("2a822851-5abe-4fa0-848d-2113f15e9b6e"), "Hard" },
                    { new Guid("39f6a494-1bcd-4479-9cc0-57d85401833c"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0d9676bc-ed5f-4dcb-ab4c-e637d4f74c5a"), "WGN", "Wellington", null },
                    { new Guid("84a04711-e402-43d2-9ff9-2549e2c169e0"), "AKL", "Auckland", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.earthtrekkers.com%2Fauckland-itinerary%2F&psig=AOvVaw2s8i9SRBtXjjjf7RsnlXqB&ust=1748608465176000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCNCCmKvYyI0DFQAAAAAdAAAAABAE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("16bdc40b-10a3-4641-8baf-cbf22181cfbc"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2a822851-5abe-4fa0-848d-2113f15e9b6e"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("39f6a494-1bcd-4479-9cc0-57d85401833c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0d9676bc-ed5f-4dcb-ab4c-e637d4f74c5a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("84a04711-e402-43d2-9ff9-2549e2c169e0"));
        }
    }
}
