namespace Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbObrasMusicale
    {
        [Key]
        public int idObra { get; set; }

        public int idAutor { get; set; }

        [Required]
        [StringLength(50)]
        public string codigoObra { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string genero { get; set; }

        [Required]
        [StringLength(50)]
        public string instrumento { get; set; }

        [Required]
        [StringLength(100)]
        public string ruta { get; set; }

        public virtual tbAutor tbAutor { get; set; }
    }
}
