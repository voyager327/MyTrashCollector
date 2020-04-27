using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class EndDateTemporarySuspensionDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf640f7-90d6-4084-82a5-c08e7524e3fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2b55d1-268c-43ef-a1f0-4e35da702933");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTemporarySuspension",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c9e1097-779a-49f6-bdca-103f8dce194e", "60158309-980d-4fed-b2a7-76c4f0a19802", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "266c36c2-f4eb-47f6-b0da-54eedff364a1", "9a1f92b0-8791-48c3-a97b-7f8039192ca8", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c9e1097-779a-49f6-bdca-103f8dce194e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266c36c2-f4eb-47f6-b0da-54eedff364a1");

            migrationBuilder.DropColumn(
                name: "EndDateTemporarySuspension",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a2b55d1-268c-43ef-a1f0-4e35da702933", "13528827-573a-4412-bd25-8d98056f0c1d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cf640f7-90d6-4084-82a5-c08e7524e3fd", "ff955097-98dd-43c8-b24a-c44ab8cf0de7", "Employee", "EMPLOYEE" });
        }
    }
}
