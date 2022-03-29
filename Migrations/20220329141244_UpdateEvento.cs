using Microsoft.EntityFrameworkCore.Migrations;

namespace EventMarketplace.Migrations
{
    public partial class UpdateEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ValorDoTicket",
                table: "Eventos",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ValorDoTicket",
                table: "Eventos",
                type: "double",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");
        }
    }
}
