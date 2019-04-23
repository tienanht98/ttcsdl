namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_GiaOnThi
    {
        [Key]
        [StringLength(10)]
        public string ID_GiaOnThi { get; set; }

        public bool TrinhDo { get; set; }

        public bool LaHocVien { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaOnThi { get; set; }

        [Required]
        [StringLength(10)]
        public string IDKyThi { get; set; }

        public bool NhuCau { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaThi { get; set; }

        [StringLength(10)]
        public string MaKyThi { get; set; }

        public virtual TTCSDL_HocVien TTCSDL_HocVien { get; set; }

        public virtual TTCSDL_NhuCau TTCSDL_NhuCau { get; set; }

        public virtual TTCSDL_TrinhDo TTCSDL_TrinhDo { get; set; }
    }
}
