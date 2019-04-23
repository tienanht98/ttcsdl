namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCDL_ThiSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCDL_ThiSinh()
        {
            TTCSDL_DSNopTien = new HashSet<TTCSDL_DSNopTien>();
        }

        [Key]
        [StringLength(10)]
        public string IDThiSinh { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SoCMT { get; set; }

        public bool LaHocVien { get; set; }

        public bool NhuCau { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SoDienThoai { get; set; }

        public bool TrinhDo { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_DSNopTien> TTCSDL_DSNopTien { get; set; }
    }
}
