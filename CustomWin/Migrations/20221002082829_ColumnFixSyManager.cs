using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomWin.Migrations
{
    public partial class ColumnFixSyManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SyManagerID",
                table: "SystemManagers",
                newName: "SyManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SyManagerId",
                table: "SystemManagers",
                newName: "SyManagerId");
        }
    }
}
