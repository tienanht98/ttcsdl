namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_DanhSachThi
    {
        [Key]
        [StringLength(10)]
        public string SBD { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHoiDongThi { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNopTien { get; set; }

        public virtual TTCSDL_DSNopTien TTCSDL_DSNopTien { get; set; }

        public virtual TTCSDL_HoiDongThi TTCSDL_HoiDongThi { get; set; }
    }
}
