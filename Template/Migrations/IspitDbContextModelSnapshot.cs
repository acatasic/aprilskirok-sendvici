﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template.Models;

namespace Template.Migrations
{
    [DbContext(typeof(IspitDbContext))]
    partial class IspitDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProdavnicaSastojak", b =>
                {
                    b.Property<int>("ProdavnicaID")
                        .HasColumnType("int");

                    b.Property<int>("SastojakID")
                        .HasColumnType("int");

                    b.HasKey("ProdavnicaID", "SastojakID");

                    b.HasIndex("SastojakID");

                    b.ToTable("ProdavnicaSastojak");
                });

            modelBuilder.Entity("Template.Models.Prodavnica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Zarada")
                        .HasColumnType("int");

                    b.Property<int>("brojStolova")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Prodavnica");
                });

            modelBuilder.Entity("Template.Models.Proizvod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProdavnicaID")
                        .HasColumnType("int");

                    b.Property<int>("cena")
                        .HasColumnType("int")
                        .HasColumnName("Cena");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Naziv");

                    b.HasKey("ID");

                    b.HasIndex("ProdavnicaID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("Template.Models.ProizvodSastojak", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<int?>("SastojakID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProizvodID");

                    b.HasIndex("SastojakID");

                    b.ToTable("ProizvodSastojak");
                });

            modelBuilder.Entity("Template.Models.Sastojak", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sastojak");
                });

            modelBuilder.Entity("ProdavnicaSastojak", b =>
                {
                    b.HasOne("Template.Models.Prodavnica", null)
                        .WithMany()
                        .HasForeignKey("ProdavnicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Template.Models.Sastojak", null)
                        .WithMany()
                        .HasForeignKey("SastojakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Template.Models.Proizvod", b =>
                {
                    b.HasOne("Template.Models.Prodavnica", "Prodavnica")
                        .WithMany("Proizvod")
                        .HasForeignKey("ProdavnicaID");

                    b.Navigation("Prodavnica");
                });

            modelBuilder.Entity("Template.Models.ProizvodSastojak", b =>
                {
                    b.HasOne("Template.Models.Proizvod", "Proizvod")
                        .WithMany("ProizvodSastojak")
                        .HasForeignKey("ProizvodID");

                    b.HasOne("Template.Models.Sastojak", "Sastojak")
                        .WithMany("ProizvodSastojak")
                        .HasForeignKey("SastojakID");

                    b.Navigation("Proizvod");

                    b.Navigation("Sastojak");
                });

            modelBuilder.Entity("Template.Models.Prodavnica", b =>
                {
                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("Template.Models.Proizvod", b =>
                {
                    b.Navigation("ProizvodSastojak");
                });

            modelBuilder.Entity("Template.Models.Sastojak", b =>
                {
                    b.Navigation("ProizvodSastojak");
                });
#pragma warning restore 612, 618
        }
    }
}
