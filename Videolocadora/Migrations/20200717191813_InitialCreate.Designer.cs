﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Videolocadora.Model;

namespace Videolocadora.Migrations
{
    [DbContext(typeof(FilmesContext))]
    [Migration("20200717191813_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Videolocadora.Model.FilmesAtributos", b =>
                {
                    b.Property<int>("codFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("anoLancamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)");

                    b.Property<bool>("ativo")
                        .HasColumnType("bit");

                    b.Property<string>("classificacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("dataCadastro")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("imagem")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("observacao")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("codFilme");

                    b.ToTable("FilmesAtributos");
                });
#pragma warning restore 612, 618
        }
    }
}
