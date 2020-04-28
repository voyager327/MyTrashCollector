using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedTrashPickUpByZipCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "697a10f6-b359-4bf2-97f2-f8d63f20917c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7f48dfe-30b1-486d-ae73-c7840ff5755a");

            migrationBuilder.RenameColumn(
                name: "Zipcode",
                table: "Employees",
                newName: "ZipCode");

            migrationBuilder.AddColumn<int>(
                name: "TrashPickUpByZipCode",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51121ddf-c93a-4270-b9d1-d7d8049bc30d", "7427bde4-87a4-42c1-a5a7-6f077a28cd67", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe5c3d38-c635-4b48-a694-aba97c01b889", "c587cd76-1af1-4f45-95f7-6baacca9c17e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51121ddf-c93a-4270-b9d1-d7d8049bc30d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe5c3d38-c635-4b48-a694-aba97c01b889");

            migrationBuilder.DropColumn(
                name: "TrashPickUpByZipCode",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Employees",
                newName: "Zipcode");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7f48dfe-30b1-486d-ae73-c7840ff5755a", "adb085f7-ec83-4cfb-91b3-591c2bed51ee", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "697a10f6-b359-4bf2-97f2-f8d63f20917c", "4272d16b-667c-4178-96db-f097843c9183", "Employee", "EMPLOYEE" });
        }
    }
}
