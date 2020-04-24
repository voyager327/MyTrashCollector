using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedPickUpDayProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "817286ac-2be6-4c8c-b39c-c7d3f1fb0d06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebb6ae89-eac4-4e3b-b55d-f345b320aa8b");

            migrationBuilder.AddColumn<string>(
                name: "PickUpDay",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d35b4285-d1ce-4f1d-8a46-6c18d1e27057", "ee36bc5f-d2eb-4d8f-90f9-27084d1f9f2f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec833dff-b0cf-4a53-af6a-de78efdd95fe", "acb50f8c-5388-4699-992b-4d6e21b90450", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d35b4285-d1ce-4f1d-8a46-6c18d1e27057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec833dff-b0cf-4a53-af6a-de78efdd95fe");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebb6ae89-eac4-4e3b-b55d-f345b320aa8b", "13fce627-2813-4666-84a9-21eddbbeed39", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "817286ac-2be6-4c8c-b39c-c7d3f1fb0d06", "eefa10c7-6af9-4ea8-b07f-fb9597e3b992", "Employee", "EMPLOYEE" });
        }
    }
}
