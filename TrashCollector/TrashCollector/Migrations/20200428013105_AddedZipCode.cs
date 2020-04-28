using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedZipCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c9e1097-779a-49f6-bdca-103f8dce194e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "266c36c2-f4eb-47f6-b0da-54eedff364a1");

            migrationBuilder.AlterColumn<int>(
                name: "Zipcode",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7f48dfe-30b1-486d-ae73-c7840ff5755a", "adb085f7-ec83-4cfb-91b3-591c2bed51ee", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "697a10f6-b359-4bf2-97f2-f8d63f20917c", "4272d16b-667c-4178-96db-f097843c9183", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697a10f6-b359-4bf2-97f2-f8d63f20917c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7f48dfe-30b1-486d-ae73-c7840ff5755a");

            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c9e1097-779a-49f6-bdca-103f8dce194e", "60158309-980d-4fed-b2a7-76c4f0a19802", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "266c36c2-f4eb-47f6-b0da-54eedff364a1", "9a1f92b0-8791-48c3-a97b-7f8039192ca8", "Employee", "EMPLOYEE" });
        }
    }
}
