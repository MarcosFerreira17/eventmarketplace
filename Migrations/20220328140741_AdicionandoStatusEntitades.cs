using Microsoft.EntityFrameworkCore.Migrations;

namespace EventMarketplace.Migrations
{
    public partial class AdicionandoStatusEntitades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ShowHouses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Events",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ShowHouses");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Events");
        }
    }
}
