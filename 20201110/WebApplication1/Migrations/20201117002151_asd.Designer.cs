﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201117002151_asd")]
    partial class asd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApplication1.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("detalleId");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT")
                        .HasColumnName("fecha");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnType("int(5)")
                        .HasColumnName("tiempo");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("WebApplication1.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("recursoId");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Recurso");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("WebApplication1.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("tareaId");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(10)")
                        .HasColumnName("estado");

                    b.Property<int>("Estimacion")
                        .HasColumnType("int(2)")
                        .HasColumnName("estimacion");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("titulo");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("TEXT")
                        .HasColumnName("vencimiento");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("WebApplication1.Usuario", b =>
                {
                    b.Property<int>("UsuarioPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("usuarioId");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("varchar(12)")
                        .HasColumnName("clave");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Usuario");

                    b.HasKey("UsuarioPK");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WebApplication1.Detalle", b =>
                {
                    b.HasOne("WebApplication1.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Tarea", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recurso");

                    b.Navigation("Tarea");
                });

            modelBuilder.Entity("WebApplication1.Recurso", b =>
                {
                    b.HasOne("WebApplication1.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WebApplication1.Tarea", b =>
                {
                    b.HasOne("WebApplication1.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Responsable");
                });
#pragma warning restore 612, 618
        }
    }
}
