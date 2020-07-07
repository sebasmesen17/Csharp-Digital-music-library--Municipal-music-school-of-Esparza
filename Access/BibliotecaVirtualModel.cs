namespace Access
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BibliotecaVirtualModel : DbContext
    {
        public BibliotecaVirtualModel()
            : base("name=BibliotecaVirtualModel")
        {
        }

        public virtual DbSet<tbAdministrador> tbAdministradors { get; set; }
        public virtual DbSet<tbAutor> tbAutors { get; set; }
        public virtual DbSet<tbObrasMusicale> tbObrasMusicales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbAdministrador>()
                .Property(e => e.cedula)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdministrador>()
                .Property(e => e.nombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdministrador>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<tbAdministrador>()
                .Property(e => e.contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<tbAutor>()
                .Property(e => e.nombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<tbAutor>()
                .Property(e => e.fechaNacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<tbAutor>()
                .Property(e => e.informacion)
                .IsUnicode(false);

            modelBuilder.Entity<tbAutor>()
                .HasMany(e => e.tbObrasMusicales)
                .WithRequired(e => e.tbAutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbObrasMusicale>()
                .Property(e => e.codigoObra)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicale>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicale>()
                .Property(e => e.genero)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicale>()
                .Property(e => e.instrumento)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicale>()
                .Property(e => e.ruta)
                .IsUnicode(false);
        }
    }
}
