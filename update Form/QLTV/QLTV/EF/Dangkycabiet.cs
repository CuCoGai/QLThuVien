namespace QLTV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dangkycabiet")]
    public partial class Dangkycabiet
    {
        [StringLength(10)]
        public string sachma { get; set; }

        [Key]
        [StringLength(10)]
        public string sodangky { get; set; }

        public DateTime? ngayvaoso { get; set; }

        [StringLength(10)]
        public string khoma { get; set; }

        public virtual Khosach Khosach { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
