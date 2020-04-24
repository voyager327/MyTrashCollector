using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedOneTimePickUpSpecificDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d35b4285-d1ce-4f1d-8a46-6c18d1e27057");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec833dff-b0cf-4a53-af6a-de78efdd95fe");

            migrationBuilder.AddColumn<string>(
                name: "OneTimePickUpSpecificDate",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24592dbc-08d6-4e34-b1ad-b342dc3d7b23", "40016528-3005-466b-8e03-bee070e0a24f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc2005a2-1f26-4339-bd3c-7f710564dd6c", "fc8c50b6-ac2e-4844-b5e8-9113a2aa33c5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24592dbc-08d6-4e34-b1ad-b342dc3d7b23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc2005a2-1f26-4339-bd3c-7f710564dd6c");

            migrationBuilder.DropColumn(
                name: "OneTimePickUpSpecificDate",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d35b4285-d1ce-4f1d-8a46-6c18d1e27057", "ee36bc5f-d2eb-4d8f-90f9-27084d1f9f2f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec833dff-b0cf-4a53-af6a-de78efdd95fe", "acb50f8c-5388-4699-992b-4d6e21b90450", "Employee", "EMPLOYEE" });
        }
    }
}
