﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testefcore.DAO;

#nullable disable

namespace testefcore.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20221205160603_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("testefcore.models.Medicamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pacienteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("pacienteid");

                    b.ToTable("Medicamento");
                });

            modelBuilder.Entity("testefcore.models.Paciente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("dado_Alta")
                        .HasColumnType("bit");

                    b.Property<string>("diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dias_Ingresado")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pronostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("testefcore.models.Prueba", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pacienteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("pacienteid");

                    b.ToTable("Prueba");
                });

            modelBuilder.Entity("testefcore.models.Medicamento", b =>
                {
                    b.HasOne("testefcore.models.Paciente", "paciente")
                        .WithMany("medicacion")
                        .HasForeignKey("pacienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("testefcore.models.Prueba", b =>
                {
                    b.HasOne("testefcore.models.Paciente", "paciente")
                        .WithMany("pruebas")
                        .HasForeignKey("pacienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("testefcore.models.Paciente", b =>
                {
                    b.Navigation("medicacion");

                    b.Navigation("pruebas");
                });
#pragma warning restore 612, 618
        }
    }
}
