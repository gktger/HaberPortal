namespace HaberPortal.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Haber")]
    public partial class Haber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haber()
        {
            Resim = new HashSet<Resim>();
            Yorum = new HashSet<Yorum>();
            Etiket = new HashSet<Etiket>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string Baslik { get; set; }

        [Required]
        [StringLength(250)]
        public string Ozet { get; set; }

        [Required]
        public string Icerik { get; set; }

        public DateTime YayinTarihi { get; set; }

        public Guid? YazarID { get; set; }

        public int KategoriID { get; set; }

        public int HaberTipID { get; set; }

        [Required]
        [StringLength(200)]
        public string ResimYol { get; set; }

        [Required]
        [StringLength(200)]
        public string KucukResimYol { get; set; }

        public int Goruntulenme { get; set; }

        public virtual HaberTip HaberTip { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resim> Resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etiket> Etiket { get; set; }
    }
}
