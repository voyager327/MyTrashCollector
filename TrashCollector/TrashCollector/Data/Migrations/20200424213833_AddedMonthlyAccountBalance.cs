using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedMonthlyAccountBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24592dbc-08d6-4e34-b1ad-b342dc3d7b23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc2005a2-1f26-4339-bd3c-7f710564dd6c");

            migrationBuilder.AddColumn<double>(
                name: "MonthlyAccountBalance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c03b5ab7-cda7-4b5b-8457-0ce04fb5e035", "b37115e2-2843-4a69-8f19-00baab511875", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff2c55f2-8e76-4e6b-8e86-3657fc966122", "0d9c1782-57b7-44bc-b8bc-5ae4f9d93fbe", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c03b5ab7-cda7-4b5b-8457-0ce04fb5e035");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff2c55f2-8e76-4e6b-8e86-3657fc966122");

            migrationBuilder.DropColumn(
                name: "MonthlyAccountBalance",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24592dbc-08d6-4e34-b1ad-b342dc3d7b23", "40016528-3005-466b-8e03-bee070e0a24f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc2005a2-1f26-4339-bd3c-7f710564dd6c", "fc8c50b6-ac2e-4844-b5e8-9113a2aa33c5", "Employee", "EMPLOYEE" });
        }
    }
}
