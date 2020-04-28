using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedConfirmPickUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61f31d02-1ccf-4fa6-a991-f0a049e3bffd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7de02945-9e8e-4abd-a856-46028e1859a3");

            migrationBuilder.AddColumn<bool>(
                name: "ConfirmPickUp",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6770811-df5e-47f0-845b-b2403f9637b6", "9de7b741-4b0e-4e19-a7f5-bcac294dc168", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94115105-e9e1-4819-aaa9-9fa3b0f79625", "17bba6aa-1602-4a99-aa26-0b3bb8774dbe", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94115105-e9e1-4819-aaa9-9fa3b0f79625");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6770811-df5e-47f0-845b-b2403f9637b6");

            migrationBuilder.DropColumn(
                name: "ConfirmPickUp",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61f31d02-1ccf-4fa6-a991-f0a049e3bffd", "0a5d024b-5cb1-49a2-b3a0-62a90b3114bb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7de02945-9e8e-4abd-a856-46028e1859a3", "6ce163a8-801e-470c-8c48-3e2bba7949a0", "Employee", "EMPLOYEE" });
        }
    }
}
