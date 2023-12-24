﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RM_v2.Data.Models;

#nullable disable

namespace RM_v2.Migrations
{
    [DbContext(typeof(StockingDbContext))]
    [Migration("20231224050504_TheLastFix")]
    partial class TheLastFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("RM_v2.Objects.Accesorio", b =>
                {
                    b.Property<int>("AccesorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadBolsas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadSuelta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Importe")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("AccesorioId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("accesorios");
                });

            modelBuilder.Entity("RM_v2.Objects.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("RM_v2.Objects.Accesorio", b =>
                {
                    b.HasOne("RM_v2.Objects.Categoria", "Categoria")
                        .WithMany("Accesorios")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("RM_v2.Objects.Categoria", b =>
                {
                    b.Navigation("Accesorios");
                });
#pragma warning restore 612, 618
        }
    }
}
