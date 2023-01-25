﻿// <auto-generated />
using System;
using JogosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JogosApi.Migrations
{
    [DbContext(typeof(JogoContext))]
    [Migration("20230125141940_Trocando nome dos campos e adicionando enums de categorias")]
    partial class Trocandonomedoscamposeadicionandoenumsdecategorias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JogosApi.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Acao")
                        .HasColumnType("int");

                    b.Property<int>("Aventura")
                        .HasColumnType("int");

                    b.Property<int?>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Criador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EsporteECorrida")
                        .HasColumnType("int");

                    b.Property<int>("Estrategia")
                        .HasColumnType("int");

                    b.Property<int>("Jogadores")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plataforma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RPG")
                        .HasColumnType("int");

                    b.Property<int>("Simulacao")
                        .HasColumnType("int");

                    b.Property<int>("Temas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_GAMES");
                });
#pragma warning restore 612, 618
        }
    }
}
