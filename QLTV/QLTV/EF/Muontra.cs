namespace QLTV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Muontra")]
    public partial class Muontra
    {
        [Key]
        [StringLength(10)]
        public string sothutu { get; set; }

        [StringLength(10)]
        public string sothema { get; set; }

        [StringLength(10)]
        public string sachma { get; set; }

        [StringLength(10)]
        public string thuthuma { get; set; }

        public DateTime? ngaymuon { get; set; }

        public DateTime? ngaytra { get; set; }

        public DateTime? ngayphaitra { get; set; }

        [StringLength(50)]
        public string tinhtrangmuon { get; set; }

        [StringLength(50)]
        public string tinhtrangtra { get; set; }

        public int? soluongmuon { get; set; }

        public int? soluongtra { get; set; }

        public virtual Docgia Docgia { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual Thuthu Thuthu { get; set; }
    }
}
