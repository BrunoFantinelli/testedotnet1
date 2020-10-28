﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteLuby.Models;

namespace TesteLuby.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TesteLuby.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Desenvolvedor");
                });

            modelBuilder.Entity("TesteLuby.Models.LançamentoHora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraFinal")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("HoraInicial")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DesenvolvedorId");

                    b.ToTable("Lancamento_Hora");
                });

            modelBuilder.Entity("TesteLuby.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("TesteLuby.Models.LançamentoHora", b =>
                {
                    b.HasOne("TesteLuby.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany()
                        .HasForeignKey("DesenvolvedorId");
                });
#pragma warning restore 612, 618
        }
    }
}