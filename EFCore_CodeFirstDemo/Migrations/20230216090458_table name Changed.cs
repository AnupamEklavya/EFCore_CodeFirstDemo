using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_CodeFirstDemo.Migrations
{
    public partial class tablenameChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentSet",
                table: "DepartmentSet");

            migrationBuilder.RenameTable(
                name: "DepartmentSet",
                newName: "Departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "DepartmentSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentSet",
                table: "DepartmentSet",
                column: "DepartmentId");
        }
    }
}
