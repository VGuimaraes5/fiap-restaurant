﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelo.Infrastructure.DataProviders;

#nullable disable

namespace modelo.Infrastructure.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230804122227_Initial")]
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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

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
                            Id = new Guid("ada751db-8553-493f-b308-70bd29aed106"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Lanche"
                        },
                        new
                        {
                            Id = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Acompanhamento"
                        },
                        new
                        {
                            Id = new Guid("5117243c-b007-49e8-9a30-842ec79248ae"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Bebida"
                        },
                        new
                        {
                            Id = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sobremesa"
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

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
                            Id = new Guid("b71a3cc1-52d3-4bcd-8e54-e89548ed5b5c"),
                            Cpf = "08154831473",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Juca"
                        },
                        new
                        {
                            Id = new Guid("3404cf8e-7ebd-4fab-b8e4-5ae78013a690"),
                            Cpf = "26521727788",
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Blippi"
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.ItemPedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("Observacao");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("tb_ItemPedido", (string)null);
                });

            modelBuilder.Entity("modelo.Domain.Entities.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TipoPagamento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("tb_Pagamento", (string)null);
                });

            modelBuilder.Entity("modelo.Domain.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Senha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tb_Pedido", (string)null);
                });

            modelBuilder.Entity("modelo.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("char(36)");

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
                            Id = new Guid("24e4c228-06c3-4b10-839c-47f4770e13d2"),
                            CategoriaId = new Guid("ada751db-8553-493f-b308-70bd29aed106"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Hamburguer",
                            Valor = 8.00m
                        },
                        new
                        {
                            Id = new Guid("7e5b9406-6b51-49d4-afce-411f16e6619f"),
                            CategoriaId = new Guid("ada751db-8553-493f-b308-70bd29aed106"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Cheeseburger",
                            Valor = 9.00m
                        },
                        new
                        {
                            Id = new Guid("cece9319-2804-491d-bf78-88e86b86512a"),
                            CategoriaId = new Guid("ada751db-8553-493f-b308-70bd29aed106"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "X Salada",
                            Valor = 10.00m
                        },
                        new
                        {
                            Id = new Guid("b305111e-7cc7-4b5b-980f-cc804633e0d7"),
                            CategoriaId = new Guid("ada751db-8553-493f-b308-70bd29aed106"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "X Bacon",
                            Valor = 11.00m
                        },
                        new
                        {
                            Id = new Guid("8a194ccc-14bc-4e87-be89-59e90dd65670"),
                            CategoriaId = new Guid("ada751db-8553-493f-b308-70bd29aed106"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "X Tudo",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = new Guid("742eb5d7-5363-4f5c-a37c-7aa873f3bd61"),
                            CategoriaId = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Batata Frita Pequena",
                            Valor = 5.00m
                        },
                        new
                        {
                            Id = new Guid("ab92b843-7efb-4d88-b9d2-188a04c4fd76"),
                            CategoriaId = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Batata Frita Media",
                            Valor = 7.00m
                        },
                        new
                        {
                            Id = new Guid("b3498340-e71b-4c1f-8dae-21ef4f96ffa1"),
                            CategoriaId = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Batata Frita Grande",
                            Valor = 9.00m
                        },
                        new
                        {
                            Id = new Guid("01e4acb8-5985-428a-b354-e20b374c025b"),
                            CategoriaId = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Chicken Nuggets 4 unidades",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = new Guid("cce1a54e-9ebd-41d2-8d23-7e78c6925bf7"),
                            CategoriaId = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Chicken Nuggets 8 unidades",
                            Valor = 12.00m
                        },
                        new
                        {
                            Id = new Guid("71a1d223-c66e-45c6-9c19-a6e191972968"),
                            CategoriaId = new Guid("cf412102-35da-43d8-9c3c-b72546104c72"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Chicken Nuggets 12 unidades",
                            Valor = 16.00m
                        },
                        new
                        {
                            Id = new Guid("79295cc0-1c0e-4bde-9928-0970dacaebd0"),
                            CategoriaId = new Guid("5117243c-b007-49e8-9a30-842ec79248ae"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Coca Cola Pequena",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = new Guid("be45967b-3a27-486f-a104-35d84b3da608"),
                            CategoriaId = new Guid("5117243c-b007-49e8-9a30-842ec79248ae"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Coca Cola Media",
                            Valor = 8.00m
                        },
                        new
                        {
                            Id = new Guid("e0da5dd9-8afe-45e9-8c6b-0a93ca09fbb7"),
                            CategoriaId = new Guid("5117243c-b007-49e8-9a30-842ec79248ae"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Coca Cola Grande",
                            Valor = 10.00m
                        },
                        new
                        {
                            Id = new Guid("b428ccd2-56f7-4faf-928b-cc351fd0a33f"),
                            CategoriaId = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sorverte de Baunilha",
                            Valor = 3.00m
                        },
                        new
                        {
                            Id = new Guid("d4ce24bd-617c-44cb-a070-5427152fdc7a"),
                            CategoriaId = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sorverte de Chocolate",
                            Valor = 3.00m
                        },
                        new
                        {
                            Id = new Guid("c0653170-fd6b-40b9-8ae9-c97b5db43f2d"),
                            CategoriaId = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sorverte de Misto",
                            Valor = 3.00m
                        },
                        new
                        {
                            Id = new Guid("0072f397-144c-4c99-bc27-7e5861d92033"),
                            CategoriaId = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sundae de Baunilha",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = new Guid("a5bbefb9-194d-473d-a80f-96965a20c0cf"),
                            CategoriaId = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sundae de Chocolate",
                            Valor = 6.00m
                        },
                        new
                        {
                            Id = new Guid("b3024398-76cb-41db-905d-75485b8e14fc"),
                            CategoriaId = new Guid("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                            DataAtualizacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataCriacao = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Sundae Misto",
                            Valor = 6.00m
                        });
                });

            modelBuilder.Entity("modelo.Domain.Entities.ItemPedido", b =>
                {
                    b.HasOne("modelo.Domain.Entities.Pedido", "Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("modelo.Domain.Entities.Produto", "Produto")
                        .WithMany("ItensPedido")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("modelo.Domain.Entities.Pagamento", b =>
                {
                    b.HasOne("modelo.Domain.Entities.Pedido", "Pedido")
                        .WithOne("Pagamento")
                        .HasForeignKey("modelo.Domain.Entities.Pagamento", "PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");
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

            modelBuilder.Entity("modelo.Domain.Entities.Pedido", b =>
                {
                    b.Navigation("ItensPedido");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("modelo.Domain.Entities.Produto", b =>
                {
                    b.Navigation("ItensPedido");
                });
#pragma warning restore 612, 618
        }
    }
}