namespace Access
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbAdministrador")]
    public partial class tbAdministrador
    {
        [Key]
        [StringLength(20)]
        public string cedula { get; set; }

        [Required]
        [StringLength(50)]
        public string nombreCompleto { get; set; }

        [Required]
        [StringLength(50)]
        public string cargo { get; set; }

        [Required]
        [StringLength(50)]
        public string contrasenia { get; set; }
    }
}
