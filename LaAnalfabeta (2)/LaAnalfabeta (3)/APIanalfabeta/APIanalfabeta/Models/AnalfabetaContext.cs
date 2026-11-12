using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIanalfabeta.Models;

public partial class AnalfabetaContext : DbContext
{
    public AnalfabetaContext()
    {
    }

    public AnalfabetaContext(DbContextOptions<AnalfabetaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=analfabeta;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteId).HasName("PK__Estudian__6F768338249E8DB3");

            entity.HasIndex(e => e.Carnet, "UQ__Estudian__5E387B4D75862609").IsUnique();

            entity.HasIndex(e => e.Correo, "UQ__Estudian__60695A19E94DDE7A").IsUnique();

            entity.Property(e => e.EstudianteId)
                .ValueGeneratedNever()
                .HasColumnName("EstudianteID");
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Carnet).ValueGeneratedOnAdd();
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Curso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Estudiantes)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Estudiantes_Usuarios");
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.LibroId).HasName("PK__Libros__35A1EC8DB1C6EE99");

            entity.HasIndex(e => e.Codigo, "UQ__Libros__06370DACA693C5FA").IsUnique();

            entity.Property(e => e.LibroId).HasColumnName("LibroID");
            entity.Property(e => e.Autor)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Disponible).HasDefaultValue(true);
            entity.Property(e => e.Editorial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImagenRuta)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Isbn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.Stock).HasDefaultValue(1);
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.PrestamoId).HasName("PK__Prestamo__AA58A080DE6C73A5");

            entity.Property(e => e.PrestamoId).HasColumnName("PrestamoID");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Disponible");
            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.FechaDevolucionEsperada).HasColumnType("datetime");
            entity.Property(e => e.FechaDevolucionReal).HasColumnType("datetime");
            entity.Property(e => e.FechaPrestamo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LibroId).HasColumnName("LibroID");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.EstudianteId)
                .HasConstraintName("FK_Prestamos_Estudiantes");

            entity.HasOne(d => d.Libro).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.LibroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prestamos_Libros");

            entity.HasOne(d => d.Profesor).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.ProfesorId)
                .HasConstraintName("FK_Prestamos_Profesores");
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.HasKey(e => e.ProfesorId).HasName("PK__Profesor__4DF3F02863C0C75D");

            entity.HasIndex(e => e.Correo, "UQ__Profesor__60695A19754B1CFB").IsUnique();

            entity.HasIndex(e => e.Cedula, "UQ__Profesor__B4ADFE38189516DB").IsUnique();

            entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Profesores)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Profesores_Usuarios");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE798E91A7C57");

            entity.HasIndex(e => e.Correo, "UQ__Usuarios__60695A19D0247690").IsUnique();

            entity.HasIndex(e => e.NombreUsuario, "UQ__Usuarios__6B0F5AE00B9891CC").IsUnique();

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Contrasena)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ContrasenaHash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rol).HasMaxLength(15);
            entity.Property(e => e.RolId).HasColumnName("RolID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
