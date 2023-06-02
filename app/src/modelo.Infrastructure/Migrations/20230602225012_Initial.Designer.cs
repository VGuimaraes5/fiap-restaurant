﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelo.Infrastructure.DataProviders;

#nullable disable

namespace modelo.Infrastructure.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230602225012_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("modelo.Domain.Entities.Categoria", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("tb_Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "049ac237-48d6-4d09-bb3d-e176a9463cab",
                            Nome = "Lanche"
                        },
                        new
                        {
                            Id = "cdfe8985-4e69-453f-b569-46b626171563",
                            Nome = "Acompanhamento"
                        },
                        new
                        {
                            Id = "48c89fc1-7329-4289-a7e2-9f6e0384868c",
                            Nome = "Bebida"
                        },
                        new
                        {
                            Id = "f413da09-f169-48bb-b294-c73f7f19e0fb",
                            Nome = "Sobremesa"
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)")
                        .HasColumnName("id");

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("tb_Cliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ee225698-7b19-4042-92f4-e492f880627b",
                            CPF = "54252344881",
                            Nome = "Juca"
                        },
                        new
                        {
                            Id = "9d49d337-7afc-498b-9a90-d2529ef2e0e5",
                            CPF = "34450347889",
                            Nome = "Blippi"
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.WeatherForecast", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Date");

                    b.Property<string>("Summary")
                        .HasColumnType("varchar(36)")
                        .HasColumnName("Summary");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("integer")
                        .HasColumnName("TemperatureC");

                    b.Property<int>("TemperatureF")
                        .HasColumnType("integer")
                        .HasColumnName("TemperatureF");

                    b.HasKey("Id");

                    b.ToTable("tb_WeatherForecast", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}