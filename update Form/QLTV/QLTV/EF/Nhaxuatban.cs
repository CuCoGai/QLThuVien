namespace QLTV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhaxuatban")]
    public partial class Nhaxuatban
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nhaxuatban()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [StringLength(10)]
        public string ma { get; set; }

        [StringLength(100)]
        public string ten { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(15)]
        public string sodienthoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
