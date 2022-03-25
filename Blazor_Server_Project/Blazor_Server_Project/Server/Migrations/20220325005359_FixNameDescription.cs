using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_Server_Project.Server.Migrations
{
    public partial class FixNameDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryDescrtiption",
                table: "Categories",
                newName: "CategoryDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "Categories",
                newName: "CategoryDescrtiption");
        }
    }
}
