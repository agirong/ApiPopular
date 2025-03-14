﻿// <auto-generated />
using System;
using ApiPopular.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiPopular.Migrations
{
    [DbContext(typeof(ApiPopularContext))]
    partial class ApiPopularContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiPopular.Models.Asesores", b =>
                {
                    b.Property<int>("CodigoAsesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoAsesor"));

                    b.Property<string>("NombreAsesor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoAsesor");

                    b.ToTable("Asesores");
                });

            modelBuilder.Entity("ApiPopular.Models.Estados", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<string>("NombreEstado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstado");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ApiPopular.Models.Prestamos", b =>
                {
                    b.Property<int>("IdPrestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrestamo"));

                    b.Property<string>("TipoPrestamo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPrestamo");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("ApiPopular.Models.Solicitudes", b =>
                {
                    b.Property<int>("NoSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoSolicitud"));

                    b.Property<int>("CodigoAsesor")
                        .HasColumnType("int");

                    b.Property<string>("DireccionCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocIdentidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<int>("IdPrestamo")
                        .HasColumnType("int");

                    b.Property<double>("MontoSolicitud")
                        .HasColumnType("float");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlazoSolicitud")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoSolicitud");

                    b.ToTable("Solicitudes");
                });
#pragma warning restore 612, 618
        }
    }
}
