using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_CRUD.Contexto
{
    public class ProyectoContext : DbContext
    {
        public DbSet<Models.Libros> Libros => Set<Models.Libros>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Configuración del contexto de la base de datos
        {
            optionsBuilder.UseSqlServer("Server=PC6_LAB1\\LOCALDB#31202368;Database=BIBLIOTECA;Trusted_Connection=True;TrustServerCertificate=True;"); // Cambia la cadena de conexión según tu configuración ES        //PC6_LAB1\LOCALDB#31202368  EN CASO DE ESTAR EN CASA  VER LAS PROPIEDADES EN EL SQL 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) // Configuración del modelo
        {
            modelBuilder.Entity<Models.Libros>().ToTable("LIBROS"); // Mapea la entidad Libros a la tabla LIBROS
            modelBuilder.Entity<Models.Libros>().Property(l => l.id).HasColumnName("Id_LIBRO").ValueGeneratedOnAdd(); // Configura la columna Id_LIBRO como auto incremental
            modelBuilder.Entity<Models.Libros>().Property(l => l.nombre).HasColumnName("NOMBRE").IsRequired().HasMaxLength(100); // Configura la columna NOMBRE
            modelBuilder.Entity<Models.Libros>().Property(l => l.autor).HasColumnName("AUTOR").IsRequired().HasMaxLength(100); // Configura la columna AUTOR
            modelBuilder.Entity<Models.Libros>().Property(l => l.fechaPublicacion).HasColumnName("FECHA_PUBLICACION").IsRequired(); // Configura la columna FECHA_PUBLICACION
            modelBuilder.Entity<Models.Libros>().Property(l => l.genero).HasColumnName("GENERO").IsRequired().HasMaxLength(100); // Configura la columna GENERO
            modelBuilder.Entity<Models.Libros>().Property(l => l.editorial).HasColumnName("EDITORIAL").IsRequired().HasMaxLength(100); // Configura la columna EDITORIAL
        }

    }
}
