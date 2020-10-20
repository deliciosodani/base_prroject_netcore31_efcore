﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eClinica.Infrastructure.Data;

namespace eClinica.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201020192851_AtencionDelDia")]
    partial class AtencionDelDia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eClinica.Infrastructure.Data.Entities.AtencionDelDia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDiario")
                        .HasColumnType("int");

                    b.Property<int>("NumeroHistoria")
                        .HasColumnType("int");

                    b.Property<string>("NumeroVida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAtencion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AtencionDelDia");
                });
#pragma warning restore 612, 618
        }
    }
}
