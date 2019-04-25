namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_ChiTietHoiDongThi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Hoi_Dong_Thi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDGiaoVien { get; set; }

        public string Note { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNhiemVu { get; set; }

        public virtual TTCSDL_GiaoVien TTCSDL_GiaoVien { get; set; }

        public virtual TTCSDL_HoiDongThi TTCSDL_HoiDongThi { get; set; }

        public virtual TTCSDL_NhiemVu TTCSDL_NhiemVu { get; set; }
    }
}
