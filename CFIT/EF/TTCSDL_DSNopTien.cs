namespace CFIT.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TTCSDL_DSNopTien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TTCSDL_DSNopTien()
        {
            TTCSDL_DanhSachThi = new HashSet<TTCSDL_DanhSachThi>();
        }

        [Key]
        public int ID_NopTien { get; set; }

        public int IDThiSinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNop { get; set; }

        public int IDGia { get; set; }

        public virtual TTCDL_ThiSinh TTCDL_ThiSinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCSDL_DanhSachThi> TTCSDL_DanhSachThi { get; set; }

        public virtual TTCSDL_GiaOnThi TTCSDL_GiaOnThi { get; set; }
    }
}
