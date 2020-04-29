using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedTrashPickUpToday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a1f629a-f50b-4e79-921f-b9e53af34f54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "682b875a-c780-4ca3-8e3b-549dfd913e42");

            migrationBuilder.DropColumn(
                name: "TrashPickUpByZipCode",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "TrashPickUpToday",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa732567-7adc-4d05-9642-9d7a5e89c22e", "921e33c8-d296-4fa7-baf9-edd3b9a62012", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60b8c6e8-6002-46db-85ee-bff196e6d248", "d30b4e1e-edf4-4e53-be0f-6960fc8e3cf0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60b8c6e8-6002-46db-85ee-bff196e6d248");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa732567-7adc-4d05-9642-9d7a5e89c22e");

            migrationBuilder.DropColumn(
                name: "TrashPickUpToday",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "TrashPickUpByZipCode",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a1f629a-f50b-4e79-921f-b9e53af34f54", "6a0f69ff-bd5a-4d7b-b580-f55afea3b0db", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "682b875a-c780-4ca3-8e3b-549dfd913e42", "ec2d3ce4-ee6b-40af-91cf-21caad341315", "Employee", "EMPLOYEE" });
        }
    }
}
