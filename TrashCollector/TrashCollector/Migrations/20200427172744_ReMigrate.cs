using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class ReMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6276eb5e-4e58-4616-b3ab-649b083c0eef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac4a8b87-c22b-434e-923b-28fc7f8394fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a2b55d1-268c-43ef-a1f0-4e35da702933", "13528827-573a-4412-bd25-8d98056f0c1d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1cf640f7-90d6-4084-82a5-c08e7524e3fd", "ff955097-98dd-43c8-b24a-c44ab8cf0de7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf640f7-90d6-4084-82a5-c08e7524e3fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2b55d1-268c-43ef-a1f0-4e35da702933");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6276eb5e-4e58-4616-b3ab-649b083c0eef", "0a4f2c22-4bd7-4ec0-8cea-7d46cc145c1e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac4a8b87-c22b-434e-923b-28fc7f8394fe", "c08d2c70-21c4-47ec-a9ee-d4841e0f1583", "Employee", "EMPLOYEE" });
        }
    }
}
