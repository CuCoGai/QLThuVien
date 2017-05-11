namespace QLTV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            Dangkycabiets = new HashSet<Dangkycabiet>();
            Muontras = new HashSet<Muontra>();
        }

        [Key]
        [StringLength(10)]
        public string ma { get; set; }

        [StringLength(100)]
        public string ten { get; set; }

        [StringLength(100)]
        public string tacgia { get; set; }

        [StringLength(50)]
        public string loaisach { get; set; }

        [StringLength(10)]
        public string nhaxuatbanma { get; set; }

        public int? sotrang { get; set; }

        public int? solanxuatban { get; set; }

        public int? soluong { get; set; }

        [StringLength(100)]
        public string noidung { get; set; }

        [StringLength(20)]
        public string giatien { get; set; }

        [StringLength(20)]
        public string ngonngu { get; set; }

        [StringLength(10)]
        public string khoma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dangkycabiet> Dangkycabiets { get; set; }

        public virtual Khosach Khosach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muontra> Muontras { get; set; }

        public virtual Nhaxuatban Nhaxuatban { get; set; }
    }
}
