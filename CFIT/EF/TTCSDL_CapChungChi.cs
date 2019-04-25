namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_CapChungChi
    {
        [Key]
        public int IDCapChungChi { get; set; }

        public int IDHoiDongThi { get; set; }

        [Required]
        [StringLength(10)]
        public string SoVanBang { get; set; }

        [Required]
        [StringLength(10)]
        public string SoVaoSo { get; set; }

        [Required]
        [StringLength(50)]
        public string TenChungChi { get; set; }

        [StringLength(10)]
        public string GhiChu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayCap { get; set; }

        [Required]
        [StringLength(10)]
        public string SBD { get; set; }

        public virtual TTCSDL_DanhSachThi TTCSDL_DanhSachThi { get; set; }

        public virtual TTCSDL_HoiDongThi TTCSDL_HoiDongThi { get; set; }
    }
}
