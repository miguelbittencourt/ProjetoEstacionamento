using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estacionamento.Migrations
{
    public partial class mudancaChegadaeSaidaParaVagas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chegada",
                table: "VEICULOS");

            migrationBuilder.DropColumn(
                name: "Saida",
                table: "VEICULOS");

            migrationBuilder.AddColumn<DateTime>(
                name: "Chegada",
                table: "VAGAS",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Saida",
                table: "VAGAS",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chegada",
                table: "VAGAS");

            migrationBuilder.DropColumn(
                name: "Saida",
                table: "VAGAS");

            migrationBuilder.AddColumn<DateTime>(
                name: "Chegada",
                table: "VEICULOS",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Saida",
                table: "VEICULOS",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
