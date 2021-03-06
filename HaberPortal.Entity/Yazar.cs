namespace HaberPortal.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yazar")]
    public partial class Yazar
    {
        public Guid YazarID { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [Required]
        [StringLength(50)]
        public string SoyAdi { get; set; }

        [Required]
        [StringLength(200)]
        public string ResimYol { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(100)]
        public string Mail { get; set; }

        public int KategoriID { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}
