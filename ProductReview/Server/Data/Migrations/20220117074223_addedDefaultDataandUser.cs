using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductReview.Server.Data.Migrations
{
    public partial class addedDefaultDataandUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothings",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Review", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2021, 10, 17, 15, 42, 22, 955, DateTimeKind.Local).AddTicks(6672), new DateTime(2021, 10, 17, 15, 42, 22, 958, DateTimeKind.Local).AddTicks(4703), "Dress", "This Dress is so good", "System" });

            migrationBuilder.InsertData(
                table: "FoodAndBeverages",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Review", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2021, 10, 17, 15, 42, 22, 960, DateTimeKind.Local).AddTicks(5257), new DateTime(2021, 10, 17, 15, 42, 22, 960, DateTimeKind.Local).AddTicks(5282), "Cake", "This Cake is so delicious", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodAndBeverages",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
