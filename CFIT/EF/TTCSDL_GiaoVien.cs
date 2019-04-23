namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_GiaoVien()
        {
            TTCSDL_ChiTietHoiDongThi = new HashSet<TTCSDL_ChiTietHoiDongThi>();
        }

        [Key]
        [StringLength(10)]
        public string IDGiaoVien { get; set; }

        [Required]
        [StringLength(20)]
        public string HoDem { get; set; }

        [Required]
        [StringLength(10)]
        public string Ten { get; set; }

        [Required]
        [StringLength(50)]
        public string DonVi { get; set; }

        [Required]
        [StringLength(50)]
        public string CapBac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_ChiTietHoiDongThi> TTCSDL_ChiTietHoiDongThi { get; set; }
    }
}
