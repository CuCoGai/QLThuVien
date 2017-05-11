namespace QLTV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Docgia")]
    public partial class Docgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Docgia()
        {
            Muontras = new HashSet<Muontra>();
        }

        [Key]
        [StringLength(10)]
        public string sothe { get; set; }

        [StringLength(100)]
        public string hoten { get; set; }

        public DateTime? ngaysinh { get; set; }

        public bool? gioitinh { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string donvi { get; set; }

        [StringLength(50)]
        public string chucvu { get; set; }

        [StringLength(100)]
        public string anh { get; set; }

        public DateTime? ngaycapthe { get; set; }

        public DateTime? hanthe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muontra> Muontras { get; set; }
    }
}
