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
        public int IDThiSinh { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Column(TypeName = "numeric")]
        public long SoCMT { get; set; }

        public bool LaHocVien { get; set; }

        public bool NhuCau { get; set; }

        [Column(TypeName = "numeric")]
        public long SoDienThoai { get; set; }

        public bool TrinhDo { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual TTCSDL_GioiTinh TTCSDL_GioiTinh { get; set; }

        public virtual TTCSDL_HocVien TTCSDL_HocVien { get; set; }

        public virtual TTCSDL_NhuCau TTCSDL_NhuCau { get; set; }

        public virtual TTCSDL_TrinhDo TTCSDL_TrinhDo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_DSNopTien> TTCSDL_DSNopTien { get; set; }
    }
}
