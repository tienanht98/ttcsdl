namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_NhiemVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_NhiemVu()
        {
            TTCSDL_ChiTietHoiDongThi = new HashSet<TTCSDL_ChiTietHoiDongThi>();
        }

        [Key]
        [StringLength(10)]
        public string IDNhiemVu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhiemVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_ChiTietHoiDongThi> TTCSDL_ChiTietHoiDongThi { get; set; }
    }
}
