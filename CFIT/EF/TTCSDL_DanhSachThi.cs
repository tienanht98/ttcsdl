namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_DanhSachThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_DanhSachThi()
        {
            TTCSDL_BaiThi = new HashSet<TTCSDL_BaiThi>();
            TTCSDL_CapChungChi = new HashSet<TTCSDL_CapChungChi>();
        }

        [Key]
        [StringLength(10)]
        public string SBD { get; set; }

        public int IDHoiDongThi { get; set; }

        public int IDNopTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_BaiThi> TTCSDL_BaiThi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_CapChungChi> TTCSDL_CapChungChi { get; set; }

        public virtual TTCSDL_DSNopTien TTCSDL_DSNopTien { get; set; }

        public virtual TTCSDL_HoiDongThi TTCSDL_HoiDongThi { get; set; }
    }
}
