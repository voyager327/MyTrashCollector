using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedTemporaryPickUpSuspension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c03b5ab7-cda7-4b5b-8457-0ce04fb5e035");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff2c55f2-8e76-4e6b-8e86-3657fc966122");

            migrationBuilder.AddColumn<int>(
                name: "TemporaryPickUpSuspension",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f68cecb-b6f0-4657-bc6c-dd2807302d07", "98c510f6-bb44-43c6-bc00-2363b1378d57", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c6b3b52-06d8-406b-837d-9268984316d9", "f77ff51a-2ee0-4c3f-92c1-dbbd875d2a7d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c6b3b52-06d8-406b-837d-9268984316d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f68cecb-b6f0-4657-bc6c-dd2807302d07");

            migrationBuilder.DropColumn(
                name: "TemporaryPickUpSuspension",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c03b5ab7-cda7-4b5b-8457-0ce04fb5e035", "b37115e2-2843-4a69-8f19-00baab511875", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff2c55f2-8e76-4e6b-8e86-3657fc966122", "0d9c1782-57b7-44bc-b8bc-5ae4f9d93fbe", "Employee", "EMPLOYEE" });
        }
    }
}
