namespace QLTV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuthu")]
    public partial class Thuthu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuthu()
        {
            Muontras = new HashSet<Muontra>();
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

        [StringLength(20)]
        public string chucvu { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string tendangnhap { get; set; }

        [StringLength(10)]
        public string matkhau { get; set; }

        public bool? gioitinh { get; set; }

        public int? status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muontra> Muontras { get; set; }
    }
}
