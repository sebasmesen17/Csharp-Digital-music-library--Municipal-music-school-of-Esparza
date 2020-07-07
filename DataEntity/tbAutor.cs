namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbAutor")]
    public partial class tbAutor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbAutor()
        {
            tbObrasMusicales = new HashSet<tbObrasMusicales>();
        }

        [Key]
        public int idAutor { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreCompleto { get; set; }

        public DateTime fechaNacimiento { get; set; }

        [Required]
        [StringLength(150)]
        public string informacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbObrasMusicales> tbObrasMusicales { get; set; }
    }
}
