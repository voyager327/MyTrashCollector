using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedChargedConfirmedPickUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94115105-e9e1-4819-aaa9-9fa3b0f79625");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6770811-df5e-47f0-845b-b2403f9637b6");

            migrationBuilder.AddColumn<double>(
                name: "ChargedConfirmedPickUp",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a1f629a-f50b-4e79-921f-b9e53af34f54", "6a0f69ff-bd5a-4d7b-b580-f55afea3b0db", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "682b875a-c780-4ca3-8e3b-549dfd913e42", "ec2d3ce4-ee6b-40af-91cf-21caad341315", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ChargedConfirmedPickUp",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6770811-df5e-47f0-845b-b2403f9637b6", "9de7b741-4b0e-4e19-a7f5-bcac294dc168", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94115105-e9e1-4819-aaa9-9fa3b0f79625", "17bba6aa-1602-4a99-aa26-0b3bb8774dbe", "Employee", "EMPLOYEE" });
        }
    }
}
