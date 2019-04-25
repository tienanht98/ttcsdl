namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_BaiThi
    {
        [Key]
        public int IdBaiThi { get; set; }

        public int? DiemTracNghiem { get; set; }

        public int? DiemWord { get; set; }

        public int? DiemPowerPoint { get; set; }

        public int? DiemExcel { get; set; }

        public int? TongDiem { get; set; }

        [Required]
        [StringLength(10)]
        public string SBD { get; set; }

        public virtual TTCSDL_DanhSachThi TTCSDL_DanhSachThi { get; set; }
    }
}
