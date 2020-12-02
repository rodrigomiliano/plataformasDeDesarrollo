﻿// <auto-generated />
using System;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("BlazorApp1.Data.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("detalleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tiempo")
                        .HasColumnName("tiempo")
                        .HasColumnType("int(5)");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("BlazorApp1.Data.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("recursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Recurso")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("BlazorApp1.Data.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("tareaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .HasColumnName("estado")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("Estimacion")
                        .HasColumnName("estimacion")
                        .HasColumnType("int(2)");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnName("vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("BlazorApp1.Data.Usuario", b =>
                {
                    b.Property<int>("UsuarioPK")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("usuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnName("clave")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Usuario")
                        .HasColumnType("varchar(50)");

                    b.HasKey("UsuarioPK");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("BlazorApp1.Data.Detalle", b =>
                {
                    b.HasOne("BlazorApp1.Data.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Data.Tarea", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorApp1.Data.Recurso", b =>
                {
                    b.HasOne("BlazorApp1.Data.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorApp1.Data.Tarea", b =>
                {
                    b.HasOne("BlazorApp1.Data.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
