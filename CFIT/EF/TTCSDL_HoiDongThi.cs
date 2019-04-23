namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_HoiDongThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_HoiDongThi()
        {
            TTCSDL_DanhSachThi = new HashSet<TTCSDL_DanhSachThi>();
            TTCSDL_ChiTietHoiDongThi = new HashSet<TTCSDL_ChiTietHoiDongThi>();
        }

        [Key]
        [StringLength(10)]
        public string IDHoiDongThi { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKyThi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_DanhSachThi> TTCSDL_DanhSachThi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_ChiTietHoiDongThi> TTCSDL_ChiTietHoiDongThi { get; set; }
    }
}
