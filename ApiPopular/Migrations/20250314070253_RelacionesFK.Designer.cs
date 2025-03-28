﻿// <auto-generated />
using System;
using ApiPopular.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiPopular.Migrations
{
    [DbContext(typeof(ApiPopularContext))]
    [Migration("20250314070253_RelacionesFK")]
    partial class RelacionesFK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasIndex("CodigoAsesor");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdPrestamo");

                    b.ToTable("Solicitudes");
                });

            modelBuilder.Entity("ApiPopular.Models.Solicitudes", b =>
                {
                    b.HasOne("ApiPopular.Models.Asesores", "Asesores")
                        .WithMany()
                        .HasForeignKey("CodigoAsesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiPopular.Models.Estados", "Estados")
                        .WithMany()
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiPopular.Models.Prestamos", "Prestamos")
                        .WithMany()
                        .HasForeignKey("IdPrestamo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asesores");

                    b.Navigation("Estados");

                    b.Navigation("Prestamos");
                });
#pragma warning restore 612, 618
        }
    }
}
