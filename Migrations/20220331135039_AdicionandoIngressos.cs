using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventMarketplace.Migrations
{
    public partial class AdicionandoIngressos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacidade",
                table: "Eventos");

            migrationBuilder.AddColumn<int>(
                name: "IngressoId",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ingressos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingressos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: true),
                    ValorDaVenda = table.Column<float>(type: "float", nullable: false),
                    QuantidadeIngresso = table.Column<float>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_IngressoId",
                table: "Eventos",
                column: "IngressoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_EventoId",
                table: "Vendas",
                column: "EventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Ingressos_IngressoId",
                table: "Eventos",
                column: "IngressoId",
                principalTable: "Ingressos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Ingressos_IngressoId",
                table: "Eventos");

            migrationBuilder.DropTable(
                name: "Ingressos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_IngressoId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "IngressoId",
                table: "Eventos");

            migrationBuilder.AddColumn<int>(
                name: "Capacidade",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
