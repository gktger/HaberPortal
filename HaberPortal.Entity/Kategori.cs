namespace HaberPortal.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategori")]
    public partial class Kategori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategori()
        {
            Haber = new HashSet<Haber>();
            Kategori1 = new HashSet<Kategori>();
            Yazar = new HashSet<Yazar>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [Required]
        [StringLength(100)]
        public string Aciklama { get; set; }

        [Required]
        [StringLength(200)]
        public string ResimYol { get; set; }

        public int? UstKategoriID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Haber> Haber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategori> Kategori1 { get; set; }

        public virtual Kategori Kategori2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yazar> Yazar { get; set; }
    }
}
