using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Data
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       
            modelBuilder.Entity<Usuario>(user =>
            {
                user.ToTable("Usuario");
                user.HasKey(p => p.UsuarioPK);
                user.Property(p => p.UsuarioPK).ValueGeneratedOnAdd().HasColumnName("usuarioPK");
                user.Property(p => p.Nombre).HasColumnName("Usuario").HasColumnType("varchar(50)").IsRequired();
                user.Property(p => p.Clave).HasColumnName("Clave").HasColumnType("varchar(12)").IsRequired();
            });

            modelBuilder.Entity<Recurso>(rec =>
            {
                rec.ToTable("Recurso");
                rec.HasKey(p => p.Id);
                rec.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                rec.Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar(50)").IsRequired();
                rec.Property(p => p.UsuarioId).HasColumnName("UsuarioId").HasColumnType("int").IsRequired();
            });

            modelBuilder.Entity<Tarea>(tar =>
            {
                tar.ToTable("Tarea");
                tar.HasKey(p => p.Id);
                tar.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                tar.Property(p => p.Titulo).HasColumnName("Titulo").HasColumnType("varchar(50)").IsRequired();
                tar.Property(p => p.Vencimiento).HasColumnName("Vencimiento").IsRequired();
                tar.Property(p => p.Estimacion).HasColumnName("Estimacion").HasColumnType("int(2)").IsRequired();
                tar.Property(p => p.Estado).HasColumnName("Estado").HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Detalle>(det =>
            {
                det.ToTable("Detalle");
                det.HasKey(p => p.Id);
                det.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("Id");
                det.Property(p => p.Fecha).HasColumnName("Fecha").IsRequired();
                det.Property(p => p.Tiempo).HasColumnName("Tiempo").HasColumnType("int(5)").IsRequired();
            });
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

    }
}