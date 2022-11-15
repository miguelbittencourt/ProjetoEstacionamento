﻿// <auto-generated />
using System;
using Estacionamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estacionamento.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Estacionamento.Entidades.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("Estacionamento.Entidades.Vagas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Chegada")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Saida")
                        .HasColumnType("datetime");

                    b.Property<string>("Sigla")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VeiculoId");

                    b.ToTable("VAGAS");
                });

            modelBuilder.Entity("Estacionamento.Entidades.Veiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contato")
                        .HasColumnType("text");

                    b.Property<string>("Cor")
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<string>("NomeProprietario")
                        .HasColumnType("text");

                    b.Property<string>("Observacao")
                        .HasColumnType("text");

                    b.Property<string>("Placa")
                        .HasColumnType("text");

                    b.Property<string>("TipoVeiculo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VEICULOS");
                });

            modelBuilder.Entity("Estacionamento.Entidades.Vagas", b =>
                {
                    b.HasOne("Estacionamento.Entidades.Veiculos", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
