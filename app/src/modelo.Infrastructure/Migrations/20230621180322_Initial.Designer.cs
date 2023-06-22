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
    [Migration("20230621180322_Initial")]
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
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("tb_Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ada751db-8553-493f-b308-70bd29aed106",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Lanche"
                        },
                        new
                        {
                            Id = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Acompanhamento"
                        },
                        new
                        {
                            Id = "5117243c-b007-49e8-9a30-842ec79248ae",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Bebida"
                        },
                        new
                        {
                            Id = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sobremesa"
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Cpf")
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("tb_Cliente", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "46abf27c-5186-4674-932d-67564975c3b9",
                            Cpf = "08154831473",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Juca"
                        },
                        new
                        {
                            Id = "51a09f69-7cc0-41af-bfb2-cfbf85eb3c04",
                            Cpf = "26521727788",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Blippi"
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.Pedido", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("varchar(36)")
                        .HasColumnName("CategoriaId");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProdutoId")
                        .IsRequired()
                        .HasColumnType("varchar(36)")
                        .HasColumnName("ProdutoId");

                    b.Property<int>("Senha")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("tb_Pedido", (string)null);
                });

            modelBuilder.Entity("modelo.Domain.Entities.Produto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CategoriaId")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(19,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("tb_Produto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b203715a-fb92-42be-87f0-5ad4818949e9",
                            CategoriaId = "ada751db-8553-493f-b308-70bd29aed106",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Hamburguer",
                            Valor = 8.00m
                        },
                        new
                        {
                            Id = "10676e35-6666-4308-9366-16001a5d8d83",
                            CategoriaId = "ada751db-8553-493f-b308-70bd29aed106",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Cheeseburger",
                            Valor = 9.00m
                        },
                        new
                        {
                            Id = "c870cb04-5519-4dd2-a54d-c915b237a3c5",
                            CategoriaId = "ada751db-8553-493f-b308-70bd29aed106",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "X Salada",
                            Valor = 10.00m
                        },
                        new
                        {
                            Id = "8c769bfb-a9c0-467d-823a-f508fe303c16",
                            CategoriaId = "ada751db-8553-493f-b308-70bd29aed106",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "X Bacon",
                            Valor = 11.00m
                        },
                        new
                        {
                            Id = "93d1a2a7-b7a9-4c7d-851f-68f779717078",
                            CategoriaId = "ada751db-8553-493f-b308-70bd29aed106",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "X Tudo",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = "621a2c3d-ad46-4919-9f90-c7b01c463a59",
                            CategoriaId = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Batata Frita Pequena",
                            Valor = 5.00m
                        },
                        new
                        {
                            Id = "62d4cac5-72a9-4e52-abc5-199bdd458994",
                            CategoriaId = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Batata Frita Media",
                            Valor = 7.00m
                        },
                        new
                        {
                            Id = "f98f88b8-2fbf-4477-b46c-b5beb674137c",
                            CategoriaId = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Batata Frita Grande",
                            Valor = 9.00m
                        },
                        new
                        {
                            Id = "2b19f2ea-9c2e-40f6-a6b1-cd0acba5aaac",
                            CategoriaId = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Chicken Nuggets 4 unidades",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = "800376de-94ce-44b6-99e8-0023e3c1b233",
                            CategoriaId = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Chicken Nuggets 8 unidades",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = "48bda631-5795-49ae-929a-bb2c3154f2de",
                            CategoriaId = "cf412102-35da-43d8-9c3c-b72546104c72",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Chicken Nuggets 12 unidades",
                            Valor = 16.00m
                        },
                        new
                        {
                            Id = "a261c5ba-4683-4c3e-9034-8022f932452c",
                            CategoriaId = "5117243c-b007-49e8-9a30-842ec79248ae",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Coca Cola Pequena",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = "0337ef04-29aa-4590-aaf0-e77733cacc76",
                            CategoriaId = "5117243c-b007-49e8-9a30-842ec79248ae",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Coca Cola Media",
                            Valor = 8.00m
                        },
                        new
                        {
                            Id = "351a0ed7-2dcb-410b-825d-4b8d2245ba58",
                            CategoriaId = "5117243c-b007-49e8-9a30-842ec79248ae",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Coca Cola Grande",
                            Valor = 10.00m
                        },
                        new
                        {
                            Id = "6e6764a2-3a06-4e6b-91e5-612f99f64b93",
                            CategoriaId = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sorverte de Baunilha",
                            Valor = 3.00m
                        },
                        new
                        {
                            Id = "5626dda2-b1bb-43ef-be8a-1660d98294e8",
                            CategoriaId = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sorverte de Chocolate",
                            Valor = 3.00m
                        },
                        new
                        {
                            Id = "3dea27a7-ccd7-4487-944d-98e11bf1e19e",
                            CategoriaId = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sorverte de Misto",
                            Valor = 3.00m
                        },
                        new
                        {
                            Id = "02b8b0f1-ec86-4e8a-984c-4468615e9c30",
                            CategoriaId = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sundae de Baunilha",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = "043a99da-38a6-4f4c-90c9-61a71090ad46",
                            CategoriaId = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sundae de Chocolate",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = "982b4b57-98e5-4364-ac82-966e50fde7c9",
                            CategoriaId = "32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sundae Misto",
                            Valor = 6.00m
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("modelo.Domain.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("modelo.Domain.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("modelo.Domain.Entities.Produto", b =>
                {
                    b.HasOne("modelo.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("modelo.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}