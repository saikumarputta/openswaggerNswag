using Microsoft.EntityFrameworkCore.Migrations;

namespace openswaggerNswag.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                schema: "todocontext",
                table: "todoitems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                schema: "todocontext",
                table: "todoitems");
        }
    }
}
