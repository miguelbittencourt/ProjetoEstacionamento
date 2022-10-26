using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Estacionamento.Migrations
{
    public partial class migracaoVEICULOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VEICULOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TipoVeiculo = table.Column<string>(type: "text", nullable: true),
                    Observacao = table.Column<string>(type: "text", nullable: true),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Cor = table.Column<string>(type: "text", nullable: true),
                    Placa = table.Column<string>(type: "text", nullable: true),
                    Dono = table.Column<string>(type: "text", nullable: true),
                    Contato = table.Column<string>(type: "text", nullable: true),
                    Chegada = table.Column<DateTime>(type: "datetime", nullable: false),
                    Saida = table.Column<DateTime>(type: "datetime", nullable: false),
                    Referencia = table.Column<string>(type: "text", nullable: true),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEICULOS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VEICULOS");
        }
    }
}
