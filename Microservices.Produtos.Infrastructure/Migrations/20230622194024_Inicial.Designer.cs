﻿// <auto-generated />
using Microservices.Produtos.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microservices.Produtos.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230622194024_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Microservices.Produtos.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CodigoBarras")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NomeProduto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            CodigoBarras = "79846546",
                            NomeProduto = "Camiseta Branca",
                            Preco = 60.0,
                            Quantidade = 500.0,
                            descricao = "Camiseta Masculina"
                        },
                        new
                        {
                            ProdutoId = 2,
                            CodigoBarras = "79846546",
                            NomeProduto = "Camiseta Branca",
                            Preco = 60.0,
                            Quantidade = 500.0,
                            descricao = "Camiseta frminina"
                        },
                        new
                        {
                            ProdutoId = 3,
                            CodigoBarras = "79846546",
                            NomeProduto = "Camiseta Azul",
                            Preco = 60.0,
                            Quantidade = 500.0,
                            descricao = "Camiseta Masculina"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
