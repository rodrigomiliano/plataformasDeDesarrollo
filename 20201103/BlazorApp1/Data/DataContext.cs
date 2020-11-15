using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(usuario =>
            {
                usuario.ToTable("Usuario");
                usuario.HasKey(p => p.Id);
                usuario.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("UsuarioId");
                usuario.Property(p => p.Nombre).HasColumnName("Usuario").HasColumnType("varchar(50)").IsRequired();
                usuario.Property(p => p.Clave).HasColumnName("Clave").HasColumnType("varchar(15)").IsRequired();
            });

            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tarea");
                tarea.HasKey(p => p.Id);
                tarea.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("TareaId");
                tarea.Property(p => p.Titulo).HasColumnName("Titulo").HasColumnType("varchar(50)").IsRequired();
                tarea.Property(p => p.Vencimiento).HasColumnName("Vencimiento").IsRequired();
                tarea.Property(p => p.Estimacion).HasColumnName("Estimacion").HasColumnType("int(2)").IsRequired();
                tarea.Property(p => p.Estado).HasColumnName("Estado").HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Recurso>(recurso =>
            {
                recurso.ToTable("Recurso");
                recurso.HasKey(p => p.Id);
                recurso.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("RecursoId");
                recurso.Property(p => p.Nombre).HasColumnName("Recurso").HasColumnType("varchar(50)").IsRequired();                
            });

            modelBuilder.Entity<Detalle>(detalle =>
            {
                detalle.ToTable("Detalle");
                detalle.HasKey(p => p.Id);
                detalle.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("DetalleId");
                detalle.Property(p => p.Fecha).HasColumnName("Fecha").IsRequired();
                detalle.Property(p => p.Tiempo).HasColumnName("Tiempo").HasColumnType("int(5)").IsRequired();                
            });

            modelBuilder.Entity<TipoTarea>(tipotarea =>
            {
                tipotarea.ToTable("TipoTarea");
                tipotarea.HasKey(p => p.Id);
                tipotarea.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("TipoTareaId");
                tipotarea.Property(p => p.Nombre).HasColumnName("Nombre").HasColumnType("varchar(50)").IsRequired();                
            });

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<TipoTarea> TipoTareas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

    }
}