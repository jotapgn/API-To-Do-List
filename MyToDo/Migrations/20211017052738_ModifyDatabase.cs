using Microsoft.EntityFrameworkCore.Migrations;

namespace MyToDo.Migrations
{
    public partial class ModifyDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_All",
                table: "All");

            migrationBuilder.RenameTable(
                name: "All",
                newName: "ToDos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDos",
                table: "ToDos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDos",
                table: "ToDos");

            migrationBuilder.RenameTable(
                name: "ToDos",
                newName: "All");

            migrationBuilder.AddPrimaryKey(
                name: "PK_All",
                table: "All",
                column: "Id");
        }
    }
}
