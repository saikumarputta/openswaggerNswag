using Microsoft.EntityFrameworkCore.Migrations;

namespace openswaggerNswag.Migrations
{
    public partial class delmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                schema: "todocontext",
                table: "todoitems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                schema: "todocontext",
                table: "todoitems",
                nullable: true);
        }
    }
}
