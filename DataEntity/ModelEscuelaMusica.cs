namespace DataEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEscuelaMusica : DbContext
    {
        public ModelEscuelaMusica()
            : base("name=ModelEscuelaMusica")
        {
        }

        public virtual DbSet<tbAdministrador> tbAdministrador { get; set; }
        public virtual DbSet<tbAutor> tbAutor { get; set; }
        public virtual DbSet<tbObrasMusicales> tbObrasMusicales { get; set; }
        public virtual DbSet<VP_CNS_ConsultaObrasConAutor> VP_CNS_ConsultaObrasConAutor { get; set; }

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
                .Property(e => e.informacion)
                .IsUnicode(false);

            modelBuilder.Entity<tbAutor>()
                .HasMany(e => e.tbObrasMusicales)
                .WithRequired(e => e.tbAutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbObrasMusicales>()
                .Property(e => e.codigoObra)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicales>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicales>()
                .Property(e => e.genero)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicales>()
                .Property(e => e.instrumento)
                .IsUnicode(false);

            modelBuilder.Entity<tbObrasMusicales>()
                .Property(e => e.ruta)
                .IsUnicode(false);

            modelBuilder.Entity<VP_CNS_ConsultaObrasConAutor>()
                .Property(e => e.codigoObra)
                .IsUnicode(false);

            modelBuilder.Entity<VP_CNS_ConsultaObrasConAutor>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<VP_CNS_ConsultaObrasConAutor>()
                .Property(e => e.instrumento)
                .IsUnicode(false);

            modelBuilder.Entity<VP_CNS_ConsultaObrasConAutor>()
                .Property(e => e.ruta)
                .IsUnicode(false);

            modelBuilder.Entity<VP_CNS_ConsultaObrasConAutor>()
                .Property(e => e.genero)
                .IsUnicode(false);

            modelBuilder.Entity<VP_CNS_ConsultaObrasConAutor>()
                .Property(e => e.nombreCompleto)
                .IsUnicode(false);
        }
    }
}
