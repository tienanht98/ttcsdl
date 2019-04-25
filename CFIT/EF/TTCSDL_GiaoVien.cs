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
        public int IDGiaoVien { get; set; }

       
        [StringLength(50)]
        [Required(ErrorMessage = "Mời Nhập Họ Tên")]
        [Display(Name = "Họ và Tên")]
        public string HoTen { get; set; }

        
        [StringLength(50)]
        [Required(ErrorMessage = "Mời Nhập Đơn Vị")]
        [Display(Name = "Đơn Vị")]
        public string DonVi { get; set; }

        [Required(ErrorMessage = "Mời Nhập Cấp Bậc")]
        [StringLength(50)]
        [Display(Name = "Cấp Bậc")]
        public string CapBac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_ChiTietHoiDongThi> TTCSDL_ChiTietHoiDongThi { get; set; }
    }
}
