﻿// <auto-generated />
using System;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable


namespace Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221025123323_tabelaEmendaParlamentar")]
    partial class tabelaEmendaParlamentar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("domain.Entity.entradaProduto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("entradaProduto");
                });

            modelBuilder.Entity("Domain.Entity.Produto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("domain.Entity.saidaProduto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("saidaProduto");
                });

            modelBuilder.Entity("domain.Entity.tabelaCaixa", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tabelaCaixa");
                });

            modelBuilder.Entity("domain.Entity.tabelaContaCapital", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tabelaContaCapital");
                });

            modelBuilder.Entity("domain.Entity.tabelaContaCorrente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tabelaContaCorrente");
                });

            modelBuilder.Entity("domain.Entity.tabelaEmendaImpositiva", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tabelaEmendaImpositiva");
                });

            modelBuilder.Entity("domain.Entity.tabelaEmendaParlamentar", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Entrada")
                        .HasColumnType("REAL");

                    b.Property<float>("Saida")
                        .HasColumnType("REAL");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("validade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("tabelaEmendaParlamentar");
                });
#pragma warning restore 612, 618
        }
    }
}
