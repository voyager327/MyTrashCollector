using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedFilterCustomerPickUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51121ddf-c93a-4270-b9d1-d7d8049bc30d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe5c3d38-c635-4b48-a694-aba97c01b889");

            migrationBuilder.AddColumn<string>(
                name: "FilterCustomerPickUp",
                table: "Employees",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61f31d02-1ccf-4fa6-a991-f0a049e3bffd", "0a5d024b-5cb1-49a2-b3a0-62a90b3114bb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7de02945-9e8e-4abd-a856-46028e1859a3", "6ce163a8-801e-470c-8c48-3e2bba7949a0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61f31d02-1ccf-4fa6-a991-f0a049e3bffd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7de02945-9e8e-4abd-a856-46028e1859a3");

            migrationBuilder.DropColumn(
                name: "FilterCustomerPickUp",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51121ddf-c93a-4270-b9d1-d7d8049bc30d", "7427bde4-87a4-42c1-a5a7-6f077a28cd67", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe5c3d38-c635-4b48-a694-aba97c01b889", "c587cd76-1af1-4f45-95f7-6baacca9c17e", "Employee", "EMPLOYEE" });
        }
    }
}
