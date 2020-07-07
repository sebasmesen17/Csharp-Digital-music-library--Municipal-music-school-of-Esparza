namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VP_CNS_ConsultaObrasConAutor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idObra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string codigoObra { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string instrumento { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string ruta { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string genero { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string nombreCompleto { get; set; }
    }
}
