using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06b88385-c3e4-4bdd-abb5-d98a5c201c3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a344d616-c05a-4ee2-8026-d343875e2e44");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6276eb5e-4e58-4616-b3ab-649b083c0eef", "0a4f2c22-4bd7-4ec0-8cea-7d46cc145c1e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac4a8b87-c22b-434e-923b-28fc7f8394fe", "c08d2c70-21c4-47ec-a9ee-d4841e0f1583", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "06b88385-c3e4-4bdd-abb5-d98a5c201c3b", "88b4f079-b760-4245-9735-01fb993ff223", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a344d616-c05a-4ee2-8026-d343875e2e44", "8e167776-7b1b-4516-b636-eb351083a566", "Employee", "EMPLOYEE" });
        }
    }
}
