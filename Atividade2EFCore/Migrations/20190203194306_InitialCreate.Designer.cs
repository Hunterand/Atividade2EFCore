﻿// <auto-generated />
using System;
using Atividade2EFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atividade2EFCore.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190203194306_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("Atividade2EFCore.Modelos.Agencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BancoId");

                    b.Property<string>("NumeroAgencia");

                    b.HasKey("Id");

                    b.HasIndex("BancoId");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.Banco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Conta");

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.ClienteSolicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("SolicitacaoId");

                    b.HasKey("Id");

                    b.ToTable("ClienteSolicitacoes");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgenciaId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<decimal>("Saldo");

                    b.Property<string>("Titular");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.ToTable("Conta");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Conta");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.Solicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgenciaId");

                    b.Property<int>("ClienteId");

                    b.Property<int>("ContaDepositoId");

                    b.Property<int>("ContaSaqueId");

                    b.Property<string>("TipoT");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.ContaCorrente", b =>
                {
                    b.HasBaseType("Atividade2EFCore.Modelos.Conta");

                    b.Property<decimal>("Taxa");

                    b.HasDiscriminator().HasValue("ContaCorrente");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.ContaPoupanca", b =>
                {
                    b.HasBaseType("Atividade2EFCore.Modelos.Conta");

                    b.Property<DateTime>("DataAniversario");

                    b.Property<decimal>("Juros");

                    b.HasDiscriminator().HasValue("ContaPoupanca");
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.Agencia", b =>
                {
                    b.HasOne("Atividade2EFCore.Modelos.Banco")
                        .WithMany("Agencias")
                        .HasForeignKey("BancoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Atividade2EFCore.Modelos.Conta", b =>
                {
                    b.HasOne("Atividade2EFCore.Modelos.Agencia")
                        .WithMany("Contas")
                        .HasForeignKey("AgenciaId");
                });
#pragma warning restore 612, 618
        }
    }
}
