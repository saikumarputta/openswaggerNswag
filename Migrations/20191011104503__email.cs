using Microsoft.EntityFrameworkCore.Migrations;

namespace openswaggerNswag.Migrations
{
    public partial class _email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "todocontext");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table:"todoitems"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todoitems",
                schema: "todocontext");
        }
    }
}
