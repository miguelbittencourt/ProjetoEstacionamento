using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Estacionamento.Migrations
{
    public partial class migracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Senha = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VEICULOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TipoVeiculo = table.Column<string>(type: "text", nullable: true),
                    Observacao = table.Column<string>(type: "text", nullable: true),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    Cor = table.Column<string>(type: "text", nullable: true),
                    Placa = table.Column<string>(type: "text", nullable: true),
                    NomeProprietario = table.Column<string>(type: "text", nullable: true),
                    Contato = table.Column<string>(type: "text", nullable: true),
                    Chegada = table.Column<DateTime>(type: "datetime", nullable: false),
                    Saida = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEICULOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VAGAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Sigla = table.Column<string>(type: "text", nullable: true),
                    VeiculoId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VAGAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VAGAS_VEICULOS_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "VEICULOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VAGAS_VeiculoId",
                table: "VAGAS",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "VAGAS");

            migrationBuilder.DropTable(
                name: "VEICULOS");
        }
    }
}
